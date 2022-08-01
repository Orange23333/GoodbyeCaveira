using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoodbyeCaveira.Lib.Data;
using GoodbyeCaveira.Lib.Utilities;
using GoodbyeCaveira.UI;

namespace GoodbyeCaveira
{
    public partial class Form1
    {
		public static readonly string[] TargetImageNames = { "RainbowSix.exe", "RainbowSix_BE.exe", "BEService.exe" };

		private object actionLock = new object();
		private bool actionWorking = false;

		private void button_Action_Click(object sender, EventArgs e)
		{
			Action();
		}

		private void Action()
		{
			bool flag;

			lock (actionLock)
			{
				if (actionWorking)
				{
					flag = true;
				}
				else
				{
					actionWorking = true;
					flag = false;
				}
			}
			if (flag)
			{
				LogHelper.Write(LogHelper.Type_Info, "The action has been started.");
				return;
			}

			//Task.Run(() =>
			//{
			//	string text = "RUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUN!!!";
			//	Log log = LogHelper.Write(LogHelper.Type_Info, "");
			//	for (int i = 0; i < text.Length; i++)
			//	{
			//		log.Text += text[i];
			//		this.Invoke(() => { ((ILogList)logList).LogList_Refresh(); });
			//		Task.Delay(10).Wait();
			//	}
			//});

			Task.Run(() =>
			{
				Cmd.TaskKill(TargetImageNames);

				LogHelper.Write(LogHelper.Type_Info, "Goodbye Caveira!");
				LogHelper.Write(LogHelper.Type_Info, "如果运行不正常，可以试试用管理员权限启动本程序。（注意：本程序开源，并且可信下载来源是Github用户Orange23333，或者https://www.ourorangenet.com）");
				LogHelper.Write(LogHelper.Type_Info, "If execution didn't achieve expectation, you could try to use administrator privileges to boot this program. (ATTENTION: This program is open source. The only 2 trusted origin are Orange23333 on Github and https://www.ourorangenet.com)");

				this.BeginInvoke(() =>
				{
					actionWorking = false;
				});
			});
		}
	}
}
