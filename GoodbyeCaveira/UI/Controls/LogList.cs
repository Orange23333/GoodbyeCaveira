using GoodbyeCaveira.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodbyeCaveira.UI.Controls
{
	public partial class LogList : UserControl, ILogList
	{
		protected object LogListLock = new object();

		protected List<Log> logs = new List<Log>();
		public Log[] LogList_Logs { get { return logs.ToArray(); } } //get应该没有lock的必要

		public LogList()
		{
			InitializeComponent();
		}

		private void LogList_Load(object sender, EventArgs e)
		{
			this.listBox_Logs.Items.Clear();
		}

		protected object LogList_RefreshingLock = new object();
		protected object LogList_RefreshLock = new object();
		protected bool LogList_Refreshing = false;
		protected bool LogList_WaitingRefresh = false;
		public void LogList_Refresh()
		{
			int cmd = 0;

			lock (LogList_RefreshingLock)
			{
				if (LogList_Refreshing && !LogList_WaitingRefresh)
				{
					LogList_WaitingRefresh = true;
					cmd = 2;
				}
				else if (!LogList_WaitingRefresh)
				{
					LogList_Refreshing = true;
					cmd = 1;
				}
			}

			switch (cmd)
			{
				case 1:
					LogList_RefreshImmediately();
					lock (LogList_RefreshingLock)
					{
						LogList_Refreshing = false;
					}
					break;
				case 2:
					Task.Run(() =>
					{
						while (true)
						{
							lock (LogList_RefreshingLock)
							{
								if (!LogList_Refreshing)
								{
									break;
								}
							}
							Task.Delay(100).Wait();
						}

						this.Invoke(() =>
						{
							LogList_RefreshImmediately();

							lock (LogList_RefreshingLock)
							{
								LogList_WaitingRefresh = false;
							}
						});
					});
					break;
				default:
					return;
			}
		}
		protected void LogList_RefreshImmediately()
		{
			lock (LogListLock)
			{
#warning 低效刷新
				this.listBox_Logs.Items.Clear();
				this.listBox_Logs.Items.AddRange(logs.ToArray());
				LogList_ScrollToBottom();
			}
		}

		public void LogList_ScrollToBottom()
		{
			lock (LogListLock)
			{
				this.listBox_Logs.TopIndex = this.listBox_Logs.Items.Count - (int)(this.listBox_Logs.Height / this.listBox_Logs.ItemHeight);
			}
		}
		
		public void LogList_Clear()
		{
			lock (LogListLock)
			{
				this.listBox_Logs.Items.Clear();
				logs.Clear();
			}
		}

		public Log LogList_NewLog(Log log)
		{
			lock (LogListLock)
			{
				logs.Add(log);
				this.listBox_Logs.Items.Add(log);
			}
			LogList_ScrollToBottom();
			return log;
		}

		private void LogList_SizeChanged(object sender, EventArgs e)
		{
			this.listBox_Logs.Size = this.ClientSize;
		}
	}
}
