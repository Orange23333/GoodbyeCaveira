using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace GoodbyeCaveira.Lib.Utilities
{
	public static class Kernel32
	{
		[DllImport("Kernel32.dll", SetLastError = true)]
		public extern static int FormatMessage(int flag, ref IntPtr source, int msgid, int langid, ref string buf, int size, ref IntPtr args);

		public static string FormatMessage(int flag)
		{
			IntPtr zeroPtr = IntPtr.Zero;
			string msg = null;
			FormatMessage(0x1300, ref zeroPtr, flag, 0, ref msg, int.MaxValue, ref zeroPtr);
			return msg;
		}
	}
}
