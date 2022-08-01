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
		public bool AutoWrap { get { return this.textBox_Logs.WordWrap; } set { this.textBox_Logs.WordWrap = value; } }

		protected object LogListLock = new object();

		protected List<Log> logs = new List<Log>();
		public Log[] LogList_Logs { get { return logs.ToArray(); } } //get应该没有lock的必要

		public LogList()
		{
			InitializeComponent();
		}

		private void LogList_Load(object sender, EventArgs e)
		{
			LogList_Clear();
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
					LogList_RefreshImmediately(true);
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
							LogList_RefreshImmediately(true);

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
		protected StringBuilder LogList_ContentStringBuilder = new StringBuilder(short.MaxValue);
		protected void LogList_RefreshImmediately(bool scrollToTheBottom = true)
		{
			lock (LogListLock)
			{
				this.textBox_Logs.Text = "";

#warning 最好可以记录Log内容是否改变，原本位置与长度，然后用replace进行更新，未改变部分不更新。
				LogList_ContentStringBuilder.Clear();
				foreach(var log in logs)
				{
					LogList_ContentStringBuilder.AppendLine(log.ToString());
				}

				if (LogList_ContentStringBuilder.Length > this.textBox_Logs.MaxLength)
				{
					this.textBox_Logs.MaxLength = LogList_ContentStringBuilder.Length;
				}
				this.textBox_Logs.Text = LogList_ContentStringBuilder.ToString();
			}
			if (scrollToTheBottom)
			{
				LogList_ScrollToBottom();
			}
		}

		public void LogList_ScrollToBottom()
		{
			lock (LogListLock)
			{
				this.textBox_Logs.Select(this.textBox_Logs.Text.Length, 0);
				this.textBox_Logs.ScrollToCaret();
			}
		}
		
		public void LogList_Clear()
		{
			lock (LogListLock)
			{
				this.textBox_Logs.Text = "";
				logs.Clear();
			}
		}

		public Log LogList_NewLog(Log log)
		{
			lock (LogListLock)
			{
				logs.Add(log);
			}

			LogList_RefreshImmediately(true);

			return log;
		}

		private void LogList_SizeChanged(object sender, EventArgs e)
		{
			this.textBox_Logs.Size = this.ClientSize;
		}
	}
}
