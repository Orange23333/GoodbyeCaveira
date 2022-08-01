using System.Text;
using System.Threading;
using System.Threading.Tasks;

using GoodbyeCaveira.Lib.Utilities;
using GoodbyeCaveira.UI.Controls;

#nullable disable

namespace GoodbyeCaveira
{
	public partial class Form1 : Form
	{
		public LogList LogList { get { return logList; } }
		private LogList logList;

		public Form1()
		{
			InitializeComponent();
			this.logList = new LogList()
			{
				Location = new Point(6, 22),
				Size = new Size(573, 236)
			};
			this.groupBox_Log.Controls.Add(logList);

			AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionEventHandler_LogList;
		}

		public void UnhandledExceptionEventHandler_LogList(object sender, UnhandledExceptionEventArgs e)
		{
			LogHelper.Write(LogHelper.Type_Error, e.ToString());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Invoke(() =>
			{
				InitHotKey();
			});

			LogHelper.Write(LogHelper.Type_Info, "Hello Caveira!");
		}

		private static object aboutBoxLock = new object();
		private static AboutBox aboutBox = null;
		private void button_About_Click(object sender, EventArgs e)
		{
			lock (aboutBoxLock)
			{
				if (aboutBox == null)
				{
					aboutBox = new AboutBox();
					aboutBox.FormClosed += aboutBox_FormClosedEventHandler;
				}
				aboutBox.Show();
				aboutBox.Activate();
			}
		}
		private static void aboutBox_FormClosedEventHandler(object sender, FormClosedEventArgs e)
		{
			lock (aboutBoxLock)
			{
				aboutBox = null;
			}
		}

		private void button_ClearLog_Click(object sender, EventArgs e)
		{
			logList?.LogList_Clear();
		}

		private void checkBox_AutoWrap_CheckStateChanged(object sender, EventArgs e)
		{
			this.logList.AutoWrap = ((CheckBox)sender).Checked;
		}
	}
}