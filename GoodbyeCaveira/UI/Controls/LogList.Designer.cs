namespace GoodbyeCaveira.UI.Controls
{
	partial class LogList
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox_Logs = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox_Logs
			// 
			this.listBox_Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.listBox_Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_Logs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listBox_Logs.ForeColor = System.Drawing.Color.Lime;
			this.listBox_Logs.FormattingEnabled = true;
			this.listBox_Logs.HorizontalScrollbar = true;
			this.listBox_Logs.ItemHeight = 14;
			this.listBox_Logs.Items.AddRange(new object[] {
            "listBox_Logs",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "100000000000000000000000000000000000000000000000000000000000000000000000000000000" +
                "0000000000000"});
			this.listBox_Logs.Location = new System.Drawing.Point(0, 0);
			this.listBox_Logs.Margin = new System.Windows.Forms.Padding(0);
			this.listBox_Logs.Name = "listBox_Logs";
			this.listBox_Logs.Size = new System.Drawing.Size(573, 98);
			this.listBox_Logs.TabIndex = 0;
			// 
			// LogList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.listBox_Logs);
			this.Name = "LogList";
			this.Size = new System.Drawing.Size(573, 106);
			this.Load += new System.EventHandler(this.LogList_Load);
			this.SizeChanged += new System.EventHandler(this.LogList_SizeChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox listBox_Logs;
	}
}
