#pragma once


namespace GoodbyeCaveira {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PictureBox^  pictureBox_Icon;
	protected: 

	private: System::Windows::Forms::StatusStrip^  statusStrip;
	private: System::Windows::Forms::Button^  button_About;
	protected: 


	private: System::Windows::Forms::Label^  label_Tips;
	private: System::Windows::Forms::GroupBox^  groupBox_HotKeys;
	private: System::Windows::Forms::Button^  button_BindAbortHotKey;



	private: System::Windows::Forms::TextBox^  textBox_AbortHotKey;

	private: System::Windows::Forms::Label^  label_AbortHotKey;
	private: System::Windows::Forms::Button^  button_BindActionHotKey;


	private: System::Windows::Forms::TextBox^  textBox_ActionHotKey;

	private: System::Windows::Forms::Label^  label_ActionHotKey;

	private: System::Windows::Forms::GroupBox^  groupBox_Commands;
	private: System::Windows::Forms::ComboBox^  comboBox_ChooseMethod;
	private: System::Windows::Forms::Button^  button_Action;



	private: System::Windows::Forms::GroupBox^  groupBox_Log;

	private: System::Windows::Forms::CheckBox^  checkBox_AutoWrap;
	private: System::Windows::Forms::Button^  button_ClearLog;
	private: System::Windows::Forms::TextBox^  textBox_LogList;



	private: System::Windows::Forms::ToolStripStatusLabel^  toolStripStatusLabel_Status;
	private: System::Windows::Forms::ToolStripProgressBar^  toolStripProgressBar_Status;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->pictureBox_Icon = (gcnew System::Windows::Forms::PictureBox());
			this->statusStrip = (gcnew System::Windows::Forms::StatusStrip());
			this->toolStripStatusLabel_Status = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->toolStripProgressBar_Status = (gcnew System::Windows::Forms::ToolStripProgressBar());
			this->button_About = (gcnew System::Windows::Forms::Button());
			this->label_Tips = (gcnew System::Windows::Forms::Label());
			this->groupBox_HotKeys = (gcnew System::Windows::Forms::GroupBox());
			this->button_BindAbortHotKey = (gcnew System::Windows::Forms::Button());
			this->textBox_AbortHotKey = (gcnew System::Windows::Forms::TextBox());
			this->label_AbortHotKey = (gcnew System::Windows::Forms::Label());
			this->button_BindActionHotKey = (gcnew System::Windows::Forms::Button());
			this->textBox_ActionHotKey = (gcnew System::Windows::Forms::TextBox());
			this->label_ActionHotKey = (gcnew System::Windows::Forms::Label());
			this->groupBox_Commands = (gcnew System::Windows::Forms::GroupBox());
			this->comboBox_ChooseMethod = (gcnew System::Windows::Forms::ComboBox());
			this->button_Action = (gcnew System::Windows::Forms::Button());
			this->groupBox_Log = (gcnew System::Windows::Forms::GroupBox());
			this->textBox_LogList = (gcnew System::Windows::Forms::TextBox());
			this->checkBox_AutoWrap = (gcnew System::Windows::Forms::CheckBox());
			this->button_ClearLog = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox_Icon))->BeginInit();
			this->statusStrip->SuspendLayout();
			this->groupBox_HotKeys->SuspendLayout();
			this->groupBox_Commands->SuspendLayout();
			this->groupBox_Log->SuspendLayout();
			this->SuspendLayout();
			// 
			// pictureBox_Icon
			// 
			this->pictureBox_Icon->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(0)), static_cast<System::Int32>(static_cast<System::Byte>(0)), 
				static_cast<System::Int32>(static_cast<System::Byte>(64)));
			this->pictureBox_Icon->ImageLocation = L"images/www.onlinewebfonts.com/home.png";
			this->pictureBox_Icon->Location = System::Drawing::Point(12, 12);
			this->pictureBox_Icon->Name = L"pictureBox_Icon";
			this->pictureBox_Icon->Size = System::Drawing::Size(185, 543);
			this->pictureBox_Icon->SizeMode = System::Windows::Forms::PictureBoxSizeMode::Zoom;
			this->pictureBox_Icon->TabIndex = 0;
			this->pictureBox_Icon->TabStop = false;
			this->pictureBox_Icon->WaitOnLoad = true;
			// 
			// statusStrip
			// 
			this->statusStrip->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {this->toolStripStatusLabel_Status, 
				this->toolStripProgressBar_Status});
			this->statusStrip->Location = System::Drawing::Point(0, 587);
			this->statusStrip->Name = L"statusStrip";
			this->statusStrip->Size = System::Drawing::Size(800, 22);
			this->statusStrip->TabIndex = 1;
			this->statusStrip->Text = L"statusStrip";
			this->statusStrip->Visible = false;
			// 
			// toolStripStatusLabel_Status
			// 
			this->toolStripStatusLabel_Status->Name = L"toolStripStatusLabel_Status";
			this->toolStripStatusLabel_Status->Size = System::Drawing::Size(143, 17);
			this->toolStripStatusLabel_Status->Text = L"Doesn\'t bind a hot key.";
			// 
			// toolStripProgressBar_Status
			// 
			this->toolStripProgressBar_Status->Name = L"toolStripProgressBar_Status";
			this->toolStripProgressBar_Status->Size = System::Drawing::Size(100, 16);
			// 
			// button_About
			// 
			this->button_About->Location = System::Drawing::Point(12, 561);
			this->button_About->Name = L"button_About";
			this->button_About->Size = System::Drawing::Size(185, 23);
			this->button_About->TabIndex = 2;
			this->button_About->Text = L"About 关于";
			this->button_About->UseVisualStyleBackColor = true;
			// 
			// label_Tips
			// 
			this->label_Tips->Font = (gcnew System::Drawing::Font(L"Microsoft YaHei UI", 9, System::Drawing::FontStyle::Bold));
			this->label_Tips->ForeColor = System::Drawing::Color::Red;
			this->label_Tips->Location = System::Drawing::Point(203, 12);
			this->label_Tips->Name = L"label_Tips";
			this->label_Tips->Size = System::Drawing::Size(585, 105);
			this->label_Tips->TabIndex = 3;
			this->label_Tips->Text = resources->GetString(L"label_Tips.Text");
			// 
			// groupBox_HotKeys
			// 
			this->groupBox_HotKeys->Controls->Add(this->button_BindAbortHotKey);
			this->groupBox_HotKeys->Controls->Add(this->textBox_AbortHotKey);
			this->groupBox_HotKeys->Controls->Add(this->label_AbortHotKey);
			this->groupBox_HotKeys->Controls->Add(this->button_BindActionHotKey);
			this->groupBox_HotKeys->Controls->Add(this->textBox_ActionHotKey);
			this->groupBox_HotKeys->Controls->Add(this->label_ActionHotKey);
			this->groupBox_HotKeys->Location = System::Drawing::Point(206, 120);
			this->groupBox_HotKeys->Name = L"groupBox_HotKeys";
			this->groupBox_HotKeys->Size = System::Drawing::Size(582, 101);
			this->groupBox_HotKeys->TabIndex = 4;
			this->groupBox_HotKeys->TabStop = false;
			this->groupBox_HotKeys->Text = L"Hot Keys 快捷键";
			// 
			// button_BindAbortHotKey
			// 
			this->button_BindAbortHotKey->Location = System::Drawing::Point(501, 71);
			this->button_BindAbortHotKey->Name = L"button_BindAbortHotKey";
			this->button_BindAbortHotKey->Size = System::Drawing::Size(75, 23);
			this->button_BindAbortHotKey->TabIndex = 5;
			this->button_BindAbortHotKey->Text = L"Bind 绑定";
			this->button_BindAbortHotKey->UseVisualStyleBackColor = true;
			this->button_BindAbortHotKey->Visible = false;
			// 
			// textBox_AbortHotKey
			// 
			this->textBox_AbortHotKey->Location = System::Drawing::Point(8, 71);
			this->textBox_AbortHotKey->Name = L"textBox_AbortHotKey";
			this->textBox_AbortHotKey->Size = System::Drawing::Size(487, 21);
			this->textBox_AbortHotKey->TabIndex = 4;
			this->textBox_AbortHotKey->Visible = false;
			// 
			// label_AbortHotKey
			// 
			this->label_AbortHotKey->AutoSize = true;
			this->label_AbortHotKey->Location = System::Drawing::Point(6, 56);
			this->label_AbortHotKey->Name = L"label_AbortHotKey";
			this->label_AbortHotKey->Size = System::Drawing::Size(65, 12);
			this->label_AbortHotKey->TabIndex = 3;
			this->label_AbortHotKey->Text = L"Abort 终止";
			this->label_AbortHotKey->Visible = false;
			// 
			// button_BindActionHotKey
			// 
			this->button_BindActionHotKey->Location = System::Drawing::Point(501, 30);
			this->button_BindActionHotKey->Name = L"button_BindActionHotKey";
			this->button_BindActionHotKey->Size = System::Drawing::Size(75, 23);
			this->button_BindActionHotKey->TabIndex = 2;
			this->button_BindActionHotKey->Text = L"Bind 绑定";
			this->button_BindActionHotKey->UseVisualStyleBackColor = true;
			// 
			// textBox_ActionHotKey
			// 
			this->textBox_ActionHotKey->Location = System::Drawing::Point(8, 32);
			this->textBox_ActionHotKey->Name = L"textBox_ActionHotKey";
			this->textBox_ActionHotKey->Size = System::Drawing::Size(487, 21);
			this->textBox_ActionHotKey->TabIndex = 1;
			// 
			// label_ActionHotKey
			// 
			this->label_ActionHotKey->AutoSize = true;
			this->label_ActionHotKey->Location = System::Drawing::Point(6, 17);
			this->label_ActionHotKey->Name = L"label_ActionHotKey";
			this->label_ActionHotKey->Size = System::Drawing::Size(71, 12);
			this->label_ActionHotKey->TabIndex = 0;
			this->label_ActionHotKey->Text = L"Action 行动";
			// 
			// groupBox_Commands
			// 
			this->groupBox_Commands->Controls->Add(this->comboBox_ChooseMethod);
			this->groupBox_Commands->Controls->Add(this->button_Action);
			this->groupBox_Commands->Location = System::Drawing::Point(206, 227);
			this->groupBox_Commands->Name = L"groupBox_Commands";
			this->groupBox_Commands->Size = System::Drawing::Size(582, 52);
			this->groupBox_Commands->TabIndex = 5;
			this->groupBox_Commands->TabStop = false;
			this->groupBox_Commands->Text = L"Commands 命令";
			// 
			// comboBox_ChooseMethod
			// 
			this->comboBox_ChooseMethod->FormattingEnabled = true;
			this->comboBox_ChooseMethod->Location = System::Drawing::Point(8, 22);
			this->comboBox_ChooseMethod->Name = L"comboBox_ChooseMethod";
			this->comboBox_ChooseMethod->Size = System::Drawing::Size(326, 20);
			this->comboBox_ChooseMethod->TabIndex = 1;
			this->comboBox_ChooseMethod->Visible = false;
			// 
			// button_Action
			// 
			this->button_Action->Location = System::Drawing::Point(340, 20);
			this->button_Action->Name = L"button_Action";
			this->button_Action->Size = System::Drawing::Size(236, 23);
			this->button_Action->TabIndex = 0;
			this->button_Action->Text = L"Action! 行动！";
			this->button_Action->UseVisualStyleBackColor = true;
			// 
			// groupBox_Log
			// 
			this->groupBox_Log->Controls->Add(this->textBox_LogList);
			this->groupBox_Log->Controls->Add(this->checkBox_AutoWrap);
			this->groupBox_Log->Controls->Add(this->button_ClearLog);
			this->groupBox_Log->Location = System::Drawing::Point(206, 285);
			this->groupBox_Log->Name = L"groupBox_Log";
			this->groupBox_Log->Size = System::Drawing::Size(582, 299);
			this->groupBox_Log->TabIndex = 6;
			this->groupBox_Log->TabStop = false;
			this->groupBox_Log->Text = L"Log 日志";
			// 
			// textBox_LogList
			// 
			this->textBox_LogList->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(0)), static_cast<System::Int32>(static_cast<System::Byte>(0)), 
				static_cast<System::Int32>(static_cast<System::Byte>(64)));
			this->textBox_LogList->ForeColor = System::Drawing::Color::Lime;
			this->textBox_LogList->Location = System::Drawing::Point(8, 20);
			this->textBox_LogList->Multiline = true;
			this->textBox_LogList->Name = L"textBox_LogList";
			this->textBox_LogList->Size = System::Drawing::Size(568, 244);
			this->textBox_LogList->TabIndex = 2;
			// 
			// checkBox_AutoWrap
			// 
			this->checkBox_AutoWrap->AutoSize = true;
			this->checkBox_AutoWrap->Checked = true;
			this->checkBox_AutoWrap->CheckState = System::Windows::Forms::CheckState::Checked;
			this->checkBox_AutoWrap->Location = System::Drawing::Point(363, 274);
			this->checkBox_AutoWrap->Name = L"checkBox_AutoWrap";
			this->checkBox_AutoWrap->Size = System::Drawing::Size(132, 16);
			this->checkBox_AutoWrap->TabIndex = 1;
			this->checkBox_AutoWrap->Text = L"Auto Wrap 自动换行";
			this->checkBox_AutoWrap->UseVisualStyleBackColor = true;
			// 
			// button_ClearLog
			// 
			this->button_ClearLog->Location = System::Drawing::Point(501, 270);
			this->button_ClearLog->Name = L"button_ClearLog";
			this->button_ClearLog->Size = System::Drawing::Size(75, 23);
			this->button_ClearLog->TabIndex = 0;
			this->button_ClearLog->Text = L"Clean 清空";
			this->button_ClearLog->UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::None;
			this->ClientSize = System::Drawing::Size(800, 609);
			this->Controls->Add(this->groupBox_Log);
			this->Controls->Add(this->groupBox_Commands);
			this->Controls->Add(this->groupBox_HotKeys);
			this->Controls->Add(this->label_Tips);
			this->Controls->Add(this->button_About);
			this->Controls->Add(this->statusStrip);
			this->Controls->Add(this->pictureBox_Icon);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->MaximumSize = System::Drawing::Size(816, 648);
			this->MinimumSize = System::Drawing::Size(816, 648);
			this->Name = L"Form1";
			this->Text = L"Goodbye Caveira!";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox_Icon))->EndInit();
			this->statusStrip->ResumeLayout(false);
			this->statusStrip->PerformLayout();
			this->groupBox_HotKeys->ResumeLayout(false);
			this->groupBox_HotKeys->PerformLayout();
			this->groupBox_Commands->ResumeLayout(false);
			this->groupBox_Log->ResumeLayout(false);
			this->groupBox_Log->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private:
		System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
			
		}
};
}

