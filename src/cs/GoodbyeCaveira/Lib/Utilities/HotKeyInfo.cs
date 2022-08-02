using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#if NET6_0_OR_GREATER
	#nullable disable
#endif

namespace GoodbyeCaveira.Lib.Utilities
{
	public struct HotKeyInfo
	{
		public string Name;
		public User32.KeyModifiers KeyModifiers;
		public Keys Key;
		public Control InvokeHandleControl;
		public HotKeyHandle HotKeyHandle;

		public override string ToString()
		{
			string name = this.Name ?? "<null>";
			string invokeHandleControlHandle = this.InvokeHandleControl == null ? "<null>" : this.InvokeHandleControl.Handle.ToString();
			string hotKeyHandle = this.HotKeyHandle == null ? "<null>" : this.HotKeyHandle.Method.Name;
			return $"{{Name = \"{name}\", Modifier Keys = {{{KeyModifiers}}}, Key = {{{Key}}}, Invoke Handle Control Handle = {invokeHandleControlHandle}, Hot Key Handle = {hotKeyHandle}}}";
		}
	}
}
