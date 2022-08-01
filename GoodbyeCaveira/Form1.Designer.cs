namespace GoodbyeCaveira
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar_Status = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel_Version = new System.Windows.Forms.ToolStripStatusLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.button_Action = new System.Windows.Forms.Button();
			this.textBox_ActionHotKey = new System.Windows.Forms.TextBox();
			this.label_ActionHotKey = new System.Windows.Forms.Label();
			this.button_BindActionHotKey = new System.Windows.Forms.Button();
			this.groupBox_HotKeys = new System.Windows.Forms.GroupBox();
			this.label_AbortHotKey = new System.Windows.Forms.Label();
			this.button_BindAbortHotKey = new System.Windows.Forms.Button();
			this.textBox_AbortHotKey = new System.Windows.Forms.TextBox();
			this.groupBox_Commands = new System.Windows.Forms.GroupBox();
			this.groupBox_Log = new System.Windows.Forms.GroupBox();
			this.button_ClearLog = new System.Windows.Forms.Button();
			this.button_About = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.groupBox_HotKeys.SuspendLayout();
			this.groupBox_Commands.SuspendLayout();
			this.groupBox_Log.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox_Icon
			// 
			this.pictureBox_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.pictureBox_Icon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.Image")));
			this.pictureBox_Icon.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_Icon.Name = "pictureBox_Icon";
			this.pictureBox_Icon.Size = new System.Drawing.Size(185, 384);
			this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Icon.TabIndex = 1;
			this.pictureBox_Icon.TabStop = false;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Status,
            this.toolStripProgressBar_Status,
            this.toolStripStatusLabel_Version});
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_Status
			// 
			this.toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
			this.toolStripStatusLabel_Status.Size = new System.Drawing.Size(143, 17);
			this.toolStripStatusLabel_Status.Text = "Doesn\'t bind a hot key.";
			// 
			// toolStripProgressBar_Status
			// 
			this.toolStripProgressBar_Status.Name = "toolStripProgressBar_Status";
			this.toolStripProgressBar_Status.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel_Version
			// 
			this.toolStripStatusLabel_Version.Name = "toolStripStatusLabel_Version";
			this.toolStripStatusLabel_Version.Size = new System.Drawing.Size(188, 17);
			this.toolStripStatusLabel_Version.Text = "version: 1.0.1.0 (2022 July 25th)";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(203, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(585, 93);
			this.label2.TabIndex = 3;
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.UseCompatibleTextRendering = true;
			// 
			// button_Action
			// 
			this.button_Action.Location = new System.Drawing.Point(6, 22);
			this.button_Action.Name = "button_Action";
			this.button_Action.Size = new System.Drawing.Size(573, 23);
			this.button_Action.TabIndex = 4;
			this.button_Action.Text = "Action! 行动！";
			this.button_Action.UseVisualStyleBackColor = true;
			this.button_Action.Click += new System.EventHandler(this.button_Action_Click);
			// 
			// textBox_ActionHotKey
			// 
			this.textBox_ActionHotKey.Location = new System.Drawing.Point(6, 39);
			this.textBox_ActionHotKey.Name = "textBox_ActionHotKey";
			this.textBox_ActionHotKey.Size = new System.Drawing.Size(495, 23);
			this.textBox_ActionHotKey.TabIndex = 5;
			this.textBox_ActionHotKey.TextChanged += new System.EventHandler(this.textBox_SetSwitchHotKey_TextChanged);
			this.textBox_ActionHotKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ActionHotKey_KeyDown);
			// 
			// label_ActionHotKey
			// 
			this.label_ActionHotKey.AutoSize = true;
			this.label_ActionHotKey.Location = new System.Drawing.Point(6, 19);
			this.label_ActionHotKey.Name = "label_ActionHotKey";
			this.label_ActionHotKey.Size = new System.Drawing.Size(72, 17);
			this.label_ActionHotKey.TabIndex = 6;
			this.label_ActionHotKey.Text = "Action 行动";
			// 
			// button_BindActionHotKey
			// 
			this.button_BindActionHotKey.Location = new System.Drawing.Point(507, 39);
			this.button_BindActionHotKey.Name = "button_BindActionHotKey";
			this.button_BindActionHotKey.Size = new System.Drawing.Size(72, 23);
			this.button_BindActionHotKey.TabIndex = 7;
			this.button_BindActionHotKey.Text = "Bind 绑定";
			this.button_BindActionHotKey.UseVisualStyleBackColor = true;
			this.button_BindActionHotKey.Click += new System.EventHandler(this.button_BindActionHotKey_Click);
			// 
			// groupBox_HotKeys
			// 
			this.groupBox_HotKeys.Controls.Add(this.label_AbortHotKey);
			this.groupBox_HotKeys.Controls.Add(this.button_BindAbortHotKey);
			this.groupBox_HotKeys.Controls.Add(this.textBox_AbortHotKey);
			this.groupBox_HotKeys.Controls.Add(this.label_ActionHotKey);
			this.groupBox_HotKeys.Controls.Add(this.button_BindActionHotKey);
			this.groupBox_HotKeys.Controls.Add(this.textBox_ActionHotKey);
			this.groupBox_HotKeys.Location = new System.Drawing.Point(203, 108);
			this.groupBox_HotKeys.Name = "groupBox_HotKeys";
			this.groupBox_HotKeys.Size = new System.Drawing.Size(585, 118);
			this.groupBox_HotKeys.TabIndex = 8;
			this.groupBox_HotKeys.TabStop = false;
			this.groupBox_HotKeys.Text = "Hot Keys 快捷键";
			// 
			// label_AbortHotKey
			// 
			this.label_AbortHotKey.AutoSize = true;
			this.label_AbortHotKey.Location = new System.Drawing.Point(6, 65);
			this.label_AbortHotKey.Name = "label_AbortHotKey";
			this.label_AbortHotKey.Size = new System.Drawing.Size(69, 17);
			this.label_AbortHotKey.TabIndex = 9;
			this.label_AbortHotKey.Text = "Abort 终止";
			this.label_AbortHotKey.Visible = false;
			// 
			// button_BindAbortHotKey
			// 
			this.button_BindAbortHotKey.Location = new System.Drawing.Point(507, 85);
			this.button_BindAbortHotKey.Name = "button_BindAbortHotKey";
			this.button_BindAbortHotKey.Size = new System.Drawing.Size(72, 23);
			this.button_BindAbortHotKey.TabIndex = 10;
			this.button_BindAbortHotKey.Text = "Bind 绑定";
			this.button_BindAbortHotKey.UseVisualStyleBackColor = true;
			this.button_BindAbortHotKey.Visible = false;
			// 
			// textBox_AbortHotKey
			// 
			this.textBox_AbortHotKey.Location = new System.Drawing.Point(6, 85);
			this.textBox_AbortHotKey.Name = "textBox_AbortHotKey";
			this.textBox_AbortHotKey.Size = new System.Drawing.Size(495, 23);
			this.textBox_AbortHotKey.TabIndex = 8;
			this.textBox_AbortHotKey.Visible = false;
			// 
			// groupBox_Commands
			// 
			this.groupBox_Commands.Controls.Add(this.button_Action);
			this.groupBox_Commands.Location = new System.Drawing.Point(203, 232);
			this.groupBox_Commands.Name = "groupBox_Commands";
			this.groupBox_Commands.Size = new System.Drawing.Size(585, 53);
			this.groupBox_Commands.TabIndex = 9;
			this.groupBox_Commands.TabStop = false;
			this.groupBox_Commands.Text = "Commands 命令";
			// 
			// groupBox_Log
			// 
			this.groupBox_Log.Controls.Add(this.button_ClearLog);
			this.groupBox_Log.Location = new System.Drawing.Point(203, 291);
			this.groupBox_Log.Name = "groupBox_Log";
			this.groupBox_Log.Size = new System.Drawing.Size(585, 134);
			this.groupBox_Log.TabIndex = 10;
			this.groupBox_Log.TabStop = false;
			this.groupBox_Log.Text = "Log 日志";
			// 
			// button_ClearLog
			// 
			this.button_ClearLog.Location = new System.Drawing.Point(504, 105);
			this.button_ClearLog.Name = "button_ClearLog";
			this.button_ClearLog.Size = new System.Drawing.Size(75, 23);
			this.button_ClearLog.TabIndex = 1;
			this.button_ClearLog.Text = "Clear 清空";
			this.button_ClearLog.UseVisualStyleBackColor = true;
			this.button_ClearLog.Click += new System.EventHandler(this.button_ClearLog_Click);
			// 
			// button_About
			// 
			this.button_About.Location = new System.Drawing.Point(12, 402);
			this.button_About.Name = "button_About";
			this.button_About.Size = new System.Drawing.Size(185, 23);
			this.button_About.TabIndex = 11;
			this.button_About.Text = "About 关于";
			this.button_About.UseVisualStyleBackColor = true;
			this.button_About.Click += new System.EventHandler(this.button_About_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_About);
			this.Controls.Add(this.groupBox_Log);
			this.Controls.Add(this.groupBox_Commands);
			this.Controls.Add(this.groupBox_HotKeys);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox_Icon);
			this.Controls.Add(this.statusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.Text = "Goodbye Caveria!";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.groupBox_HotKeys.ResumeLayout(false);
			this.groupBox_HotKeys.PerformLayout();
			this.groupBox_Commands.ResumeLayout(false);
			this.groupBox_Log.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private PictureBox pictureBox_Icon;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabel_Version;
		private Label label2;
		private ToolStripStatusLabel toolStripStatusLabel_Status;
		private Button button_Action;
		private TextBox textBox_ActionHotKey;
		private Label label_ActionHotKey;
		private Button button_BindActionHotKey;
		private GroupBox groupBox_HotKeys;
		private Label label_AbortHotKey;
		private Button button_BindAbortHotKey;
		private TextBox textBox_AbortHotKey;
		private GroupBox groupBox_Commands;
		private GroupBox groupBox_Log;
		private Button button_About;
		private Button button_ClearLog;
		private ToolStripProgressBar toolStripProgressBar_Status;
	}
}