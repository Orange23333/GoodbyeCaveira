using System;
using System.Windows.Forms;

#if NET6_0_OR_GREATER
#nullable disable
#endif

namespace GoodbyeCaveira
{
	public static class Program
	{
        public static Form1 MainWindow { get { return mainWindow; } }
        private static Form1 mainWindow = null;
        #region ===MainWindow Invoke===
        public static IAsyncResult BeginInvoke(Delegate method)
        {
            return mainWindow.BeginInvoke(method);
        }
        public static IAsyncResult BeginInvoke(Delegate method, params object[] args)
        {
            return mainWindow.BeginInvoke(method, args);
        }
        public static object EndInvoke(IAsyncResult asyncResult)
        {
            return mainWindow.EndInvoke(asyncResult);
        }
        public static object Invoke(Delegate method)
        {
            return mainWindow.Invoke(method);
        }
        public static object Invoke(Delegate method, params object[] args)
        {
            return mainWindow.Invoke(method, args);
        }
        public static bool InvokeRequired
        {
            get { return mainWindow.InvokeRequired; }
        }
        #endregion

        public static void UnhandledExceptionEventHandler_MessageBox(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Unhandled Exception Event Handler", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
#if NET6_0_OR_GREATER
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if NETCOREAPP3_0_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
#endif

            mainWindow = new Form1();
			Application.Run(mainWindow);
		}
	}
}