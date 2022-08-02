using System.Windows.Forms;

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
			this.textBox_Logs = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox_Logs
			// 
			this.textBox_Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.textBox_Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Logs.ForeColor = System.Drawing.Color.Lime;
			this.textBox_Logs.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.textBox_Logs.Location = new System.Drawing.Point(0, 0);
			this.textBox_Logs.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Logs.Multiline = true;
			this.textBox_Logs.Name = "textBox_Logs";
			this.textBox_Logs.ReadOnly = true;
			this.textBox_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_Logs.Size = new System.Drawing.Size(573, 106);
			this.textBox_Logs.TabIndex = 1;
			this.textBox_Logs.Text = "textBox";
			// 
			// LogList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.textBox_Logs);
			this.Name = "LogList";
			this.Size = new System.Drawing.Size(573, 106);
			this.Load += new System.EventHandler(this.LogList_Load);
			this.SizeChanged += new System.EventHandler(this.LogList_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private TextBox textBox_Logs;
	}
}
