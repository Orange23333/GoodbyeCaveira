using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

//using CefSharp;

using GoodbyeCaveira.Lib.Utilities;

#nullable disable

namespace GoodbyeCaveira
{
	partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();
			this.Text = String.Format("关于 {0}", AssemblyTitle);
			this.labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = String.Format("版本 {0}", AssemblyVersion);
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelAuthor.Text = AssemblyCompany;
			this.textBoxDescription.Text = AssemblyDescription;
		}

		#region 程序集特性访问器

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void AboutBox_Load(object sender, EventArgs e)
		{
			this.labelProductName.Text = "Product Name 产品名称: " + AssemblyProduct + " 🥚";
			this.labelVersion.Text = "Version 版本: " + AssemblyVersion;
			this.labelCopyright.Text = "Copyright 版权: " + AssemblyCopyright;
			this.labelAuthor.Text = "Authors 作者: " + AssemblyCompany;
			this.textBoxDescription.Text =
				"* 在Github上开源 Open source on Github: https://github.com/Orange23333/GoodbyeCaveira" + Environment.NewLine +
				"* 主界面的图标改自Icon Fonts并使用CC BY 3.0许可 Home page icon was modified from Icon Fonts is licensed by CC BY 3.0: http://www.onlinewebfonts.com/icon";

			this.Icon = new Icon("./images/www.onlinewebfonts.com/983fd501f3c35b570aac8d18fb8cd996.64x64.ico");
			SetImage_Normal();
		}

		private void SetImage_Normal()
		{
			this.logoPictureBox.Image = Image.FromFile("./images/GoodbyeCaveira.jpg");
		}
		private void SetImage_EasterEgg()
		{
			this.logoPictureBox.Image = Image.FromFile("./images/blob/null/(Unauthorized Access)/Caveira_ImInDanger.jpg");
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public static readonly string AuthorUrl = "https://github.com/Orange23333";

		private void labelAuthor_DoubleClick(object sender, EventArgs e)
		{
			void Run(string shellPath, string command)
			{
				Process process = new Process()
				{
					StartInfo = new ProcessStartInfo()
					{
						UseShellExecute = false,
						CreateNoWindow = true,
						FileName = shellPath,
						RedirectStandardInput = true
					}
				};
				process.Start();
				process.StandardInput.WriteLine(command);
				process.StandardInput.WriteLine("exit");
				process.WaitForExit();
				process.Close();
			}

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				Run(
					System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86), "cmd.exe"),
					$"start {AuthorUrl}"
				);

				LogHelper.Write(LogHelper.Type_Debug, $"start {AuthorUrl}");
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
#warning 未测试
				Run(
					"/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal",
					$"open {AuthorUrl}"
				);
				LogHelper.Write(LogHelper.Type_Debug, $"open {AuthorUrl}");
			}
			else
			{
				MessageBox.Show($"Author URL: \"{AuthorUrl}\".", "Author URL", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				LogHelper.Write(LogHelper.Type_Info, $"Author URL: \"{AuthorUrl}\".");
			}
		}

		public static readonly string LogType_EasterEgg = "Easter Egg";
		public object easterEggLock = new object();
		private bool easterEggRun = false;
		private Task easterEggTask = null;
		private void labelProductName_MouseHover(object sender, EventArgs e)
		{
			lock (easterEggLock)
			{
				if (easterEggRun)
				{
					return;
				}
				easterEggRun = true;
			}

			easterEggTask = new Task(() =>
			{
				void ResetImage()
				{
					this.BeginInvoke(() =>
					{
						if (!logoPictureBox.IsDisposed)
						{
							SetImage_Normal();
						}
						easterEggTask = null;
					});
				}

				try
				{
					this.Invoke(() =>
					{
						if (!logoPictureBox.IsDisposed)
						{
							SetImage_EasterEgg();
							LogHelper.Write(LogType_EasterEgg, "BLITZ: ♪Thomas The Tank Engine Theme♫");
							LogHelper.Write(LogType_EasterEgg, "SLEDGE: 80! ");
							LogHelper.Write(LogType_EasterEgg, "CAVEIRA: I'm in danger. ●∀●");
						}
					});
					Task.Delay(800).Wait();

					this.Invoke(() =>
					{
						if (!logoPictureBox.IsDisposed)
						{
							logoPictureBox.Image = null;
						}
					});
					Task.Delay(10).Wait();

					ResetImage();
				}
				catch (OperationCanceledException)
				{
					ResetImage();
					return;
				}
				catch (Exception ex)
				{
					this.Invoke(() =>
					{
						MessageBox.Show(ex.ToString(), "Because a error, you lost an easter egg.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
					});
					LogHelper.Write(LogType_EasterEgg, "Because a error, you lost an easter egg.");
					return;
				}
			});
			easterEggTask.Start();
		}
	}
}
