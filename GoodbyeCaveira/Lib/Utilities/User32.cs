﻿using System.Runtime.InteropServices;
using System.Text;

namespace GoodbyeCaveira.Lib.Utilities
{
	public static class User32
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[Flags]
		public enum KeyModifiers
		{
			None = 0,
			Alt = 1,
			Ctrl = 2,
			Shift = 4,
			WindowsKey = 8
		}
	}
}
