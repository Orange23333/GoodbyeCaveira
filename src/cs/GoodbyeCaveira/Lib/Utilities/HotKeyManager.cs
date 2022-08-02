using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#if NET6_0_OR_GREATER
	#nullable disable
#endif

namespace GoodbyeCaveira.Lib.Utilities
{
	/// <summary>
	/// 一个被热键管理器调用来出发热键事件的
	/// </summary>
	/// <param name="message">WndProc Message。</param>
	/// <returns>可能发生改变的message。（因为无法在这里传递ref参数，所以请将更改用return的方式传回来；传回null将定义为未改变message）</returns>
	public delegate Message HotKeyHandle(Message message);

	public sealed class HotKeyManager : IDisposable
	{
		private static SortedDictionary<int, HotKeyInfo> hotKeys = new SortedDictionary<int, HotKeyInfo>();
		public static List<HotKeyInfo> HotKeyInfos { get { return hotKeys.Values.ToList(); } }
		private class InnerWindowHandleBody : Control
		{
			private delegate void ObejectsMethod(params object[] args);

			protected override void WndProc(ref Message m)
			{
				const int WM_HOTKEY = 0x0312;

				switch (m.Msg)
				{
					case WM_HOTKEY:
						Message message = m;
						var sameId = from val in hotKeys
									 where val.Key == message.WParam.ToInt32()
									 select val;
						if (sameId.Count() == 0)
						{
							LogHelper.Write(LogHelper.Type_Warning, "A unknown hotkey event happened. (at HotKeyManager.InnerWindowHandleBody.WndProc(Message))");
						}
						else
						{
							m = (Message)(sameId.Single().Value.InvokeHandleControl.Invoke((Func<Message>)(() => {
								return sameId.Single().Value.HotKeyHandle(message);
							})));
						}
						
						break;
				}

				base.WndProc(ref m);
			}
		}
		private static InnerWindowHandleBody innerWindowHandleBody = new InnerWindowHandleBody();

		public static void Add(string name, User32.KeyModifiers keyModifier, Keys key, Control invokeHandleControl, HotKeyHandle hotKeyHandle)
		{
			HotKeyInfo hotKeyInfo = new HotKeyInfo();
			hotKeyInfo.Name = name;
			hotKeyInfo.KeyModifiers = keyModifier;
			hotKeyInfo.Key = key;
			hotKeyInfo.InvokeHandleControl = invokeHandleControl;
			hotKeyInfo.HotKeyHandle = hotKeyHandle;
			Add(hotKeyInfo);
		}
		public static void Add(HotKeyInfo hotKeyInfo)
		{
			LogHelper.Write(LogHelper.Type_Debug, $"Register hotkey( = {hotKeyInfo}).");

			if (hotKeyInfo.InvokeHandleControl == null)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The invoke handle control can't be null.", "hotKeyInfo")).ToString()); return;
			}
			if (hotKeyInfo.HotKeyHandle == null)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The hot key handle can't be null.", "hotKeyInfo")).ToString()); return;
			}
			var sameHotKey = from val in hotKeys.Values
							 where val.Key == hotKeyInfo.Key && val.KeyModifiers == hotKeyInfo.KeyModifiers
							 select val;
			if (sameHotKey.Count() > 0)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The hot key has been existed.", "hotKeyInfo")).ToString()); return;
			}
			var sameName = from val in hotKeys
						   where val.Value.Name == hotKeyInfo.Name
						   select val;
			if (sameName.Count() > 0)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The name has been existed.", "hotKeyInfo")).ToString()); return;
			}
			if (hotKeyInfo.Key == Keys.None)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The key can't be none, if you want remove it, please call Remove().", "hotKeyInfo")).ToString()); return;
			}

			if(Register(hotKeyInfo.KeyModifiers, hotKeyInfo.Key, out int newId))
			{
				hotKeys.Add(newId, hotKeyInfo);

				LogHelper.Write(LogHelper.Type_Debug, "Succeed!");
			}
			else
			{
				LogHelper.Write(LogHelper.Type_Debug, "Failed!");
			}
		}

		/// <remarks>
		/// 如果名相同且和热键相同，则不会引发异常。
		/// </remarks>
		public static void Change(string name, User32.KeyModifiers keyModifier, Keys key, Control invokeHandleControl, HotKeyHandle hotKeyHandle)
		{
			HotKeyInfo hotKeyInfo = new HotKeyInfo();
			hotKeyInfo.Name = name;
			hotKeyInfo.KeyModifiers = keyModifier;
			hotKeyInfo.Key = key;
			hotKeyInfo.InvokeHandleControl = invokeHandleControl;
			hotKeyInfo.HotKeyHandle = hotKeyHandle;
			Change(hotKeyInfo);
		}
		/// <remarks>
		/// 如果名相同且和热键相同，则不会引发异常。
		/// </remarks>
		public static void Change(HotKeyInfo hotKeyInfo)
		{
			LogHelper.Write(LogHelper.Type_Debug, $"Register hotkey( = {hotKeyInfo}).");

			var sameName = from val in hotKeys
						   where val.Value.Name == hotKeyInfo.Name
						   select val;
			if (sameName.Count() == 0)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The name doesn't exist.", "hotKeyInfo")).ToString()); return;
			}
			else if (sameName.Count() > 1)
			{
				LogHelper.Write(LogHelper.Type_Error, (new Exception("A unknow error from HotKeyManager.Change.")).ToString()); return;
			}
			if (hotKeyInfo.InvokeHandleControl == null)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The invoke handle control can't be null.", "hotKeyInfo")).ToString()); return;
			}
			if (hotKeyInfo.HotKeyHandle == null)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The hot key handle can't be null.", "hotKeyInfo")).ToString()); return;
			}
			var sameHotKey = from val in hotKeys.Values
							 where val.Key == hotKeyInfo.Key && val.KeyModifiers == hotKeyInfo.KeyModifiers
							 select val;
			if (sameHotKey.Count() > 0)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The hot key has been existed.", "hotKeyInfo")).ToString()); return;
			}
			if (hotKeyInfo.Key == Keys.None)
			{
				LogHelper.Write(LogHelper.Type_Error, (new ArgumentException("The key can't be none, if you want remove it, please call Remove().", "hotKeyInfo")).ToString()); return;
			}

			if (Register(hotKeyInfo.KeyModifiers, hotKeyInfo.Key, out int newId))
			{
				hotKeys.Remove(sameName.Single().Key);
				hotKeys.Add(newId, hotKeyInfo);

				LogHelper.Write(LogHelper.Type_Debug, "Succeed!");
			}
			else
			{
				LogHelper.Write(LogHelper.Type_Debug, "Failed!");
			}
		}

		private static bool Register(User32.KeyModifiers keyModifiers, Keys key, out int newId)
		{
			Random random = new Random();
			newId = -1;

			//MSDN中指出，调用RegisterHotKey的“线程”的所提供的热键id应当是唯一的。并且应用程序所用的id范围为0~0xBFFF；共享库所用的id范围为0xC000~0xFFFF，并且要从GlobalAddAtom获取。（迷之设计）
			while (newId < 0 || newId > 0xBFFF || hotKeys.Keys.Contains(newId))
			{
				newId = random.Next() % 0xC000;
			}
			if (User32.RegisterHotKey(innerWindowHandleBody.Handle, newId, keyModifiers, key))
			{
				return true;
			}
			else
			{
#if NET6_0_OR_GREATER
				int lasterror = Marshal.GetLastPInvokeError();
#else
				int lasterror = Marshal.GetLastWin32Error();
#endif
				LogHelper.Write(LogHelper.Type_Error, $"Register hotkey failed. (Error Code = {lasterror}, Message = \"{Kernel32.FormatMessage(lasterror)}\")");
				return false;
			}
		}

		public static void Remove(string name)
		{
			var sameNames = from val in hotKeys
						   where val.Value.Name == name
						   select val;
			if (sameNames.Count() != 1)
			{
				LogHelper.Write(LogHelper.Type_Warning, $"Unknown error: Duplicate hotkey records. (at HotKeyManager.Remove(string))");
			}


			var target = sameNames.Single();
			LogHelper.Write(LogHelper.Type_Debug, $"Remove hotkey( = {target.Value}).");

			Unregister(target.Key);
			hotKeys.Remove(target.Key);
		}

		private static void Unregister(int id)
		{
			if (!User32.UnregisterHotKey(innerWindowHandleBody.Handle, id))
			{
#if NET6_0_OR_GREATER
				int lasterror = Marshal.GetLastPInvokeError();
#else
				int lasterror = Marshal.GetLastWin32Error();
#endif

				if (hotKeys.TryGetValue(id, out var target))
				{
					LogHelper.Write(LogHelper.Type_Error, $"Unregister hotkey( = {target}) failed. (Error Code = {lasterror}, Message = \"{Kernel32.FormatMessage(lasterror)}\")");
				}
				else
				{
					LogHelper.Write(LogHelper.Type_Error, $"Unregister hotkey(id = {id}) failed. (Error Code = {lasterror}, Message = \"{Kernel32.FormatMessage(lasterror)}\")");
				}
			}
		}

		public static void Clear()
		{
			foreach (KeyValuePair<int, HotKeyInfo> temp in hotKeys)
			{
				Unregister(temp.Key);
			}
		}

#region ===IDisposable===
		// Track whether Dispose has been called.
		private bool disposed = false;

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					// Dispose managed resources.
					;
				}

				// unmanaged resources here.
				Clear();

				disposed = true;
			}
		}

		~HotKeyManager()
		{
			Dispose(disposing: false);
		}
#endregion
	}
}
