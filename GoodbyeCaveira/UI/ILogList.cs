using GoodbyeCaveira.Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCaveira.UI
{
	public interface ILogList
	{
		bool AutoWrap { get; set; }

		Log[] LogList_Logs { get; }

		void LogList_Refresh();
		void LogList_ScrollToBottom();

		void LogList_Clear();

		public virtual Log LogList_NewLog(string type, string text)
		{
			return LogList_NewLog(new Log(DateTime.Now, type, text));
		}
		public virtual Log LogList_NewLog(DateTime time, string type, string text)
		{
			return LogList_NewLog(new Log(time, type, text));
		}
		Log LogList_NewLog(Log log);
	}
}
