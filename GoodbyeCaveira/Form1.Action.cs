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
		public static readonly string R6_ImageName = "Rainbow Six";
		public static readonly string BattleEye_ImageName = "BattlEye Launcher";

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

			Cmd.TaskKill(R6_ImageName);
			Cmd.TaskKill(BattleEye_ImageName);

			LogHelper.Write(LogHelper.Type_Info, "Goodbye Caveira!");

			actionWorking = false;
		}
	}
}
