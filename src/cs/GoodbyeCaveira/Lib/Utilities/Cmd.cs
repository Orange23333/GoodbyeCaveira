using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCaveira.Lib.Utilities
{
	public class Cmd
	{
		public static void TaskKill(string[] imageNames)
		{
#if NETCOREAPP
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
#endif
				void DataReceivedEventHandler(object sender, DataReceivedEventArgs e)
				{
					if (e.Data != null)
					{
						LogHelper.Write(LogHelper.Type_Debug, $"Console: {e.Data}");
					}
				}

				Process process = new Process()
				{
					StartInfo = new ProcessStartInfo()
					{
						UseShellExecute = false,
						CreateNoWindow = true,
						FileName = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86), "cmd.exe"),
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						RedirectStandardError = true,
					},
				};
				process.Start();
				process.OutputDataReceived += DataReceivedEventHandler;
				process.ErrorDataReceived+=DataReceivedEventHandler;
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();

				foreach (string imageName in imageNames)
				{
					process.StandardInput.WriteLine($"taskkill /F /IM {imageName}");
					LogHelper.Write(LogHelper.Type_Debug, $"Execute: taskkill /F /IM \"{imageName}\"");
				}

				process.StandardInput.WriteLine("exit");
				process.WaitForExit();
				process.Close();
#if NETCOREAPP
			}
			else
			{
				LogHelper.Write(LogHelper.Type_Error, "Non-supported operation system.");
			}
#endif
		}
	}
}
