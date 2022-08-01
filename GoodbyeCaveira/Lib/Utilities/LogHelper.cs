using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoodbyeCaveira.Lib.Data;
using GoodbyeCaveira.UI;

namespace GoodbyeCaveira.Lib.Utilities
{
	public static class LogHelper
	{
		public static readonly string Type_Fatal = "Fatal";
		public static readonly string Type_Error = "Error";
		public static readonly string Type_Warning = "Warning";
		public static readonly string Type_Info = "Info";
		public static readonly string Type_Debug = "Debug";

		public static Log Write(DateTime time, string type, string text)
		{
			return (Log)(Program.Invoke(() =>
			{
				return ((ILogList)Program.MainWindow.LogList).LogList_NewLog(time, type, text);
			}));
		}
		public static Log Write(string type, string text)
		{
			return (Log)(Program.Invoke(() =>
			{
				return ((ILogList)Program.MainWindow.LogList).LogList_NewLog(type, text);
			}));
		}
		public static Log Write(Log log)
		{
			return (Log)(Program.Invoke(() =>
			{
				return ((ILogList)Program.MainWindow.LogList).LogList_NewLog(log);
			}));
		}
	}
}
