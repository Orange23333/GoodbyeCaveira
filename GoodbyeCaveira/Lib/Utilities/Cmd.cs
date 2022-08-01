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
		public static void TaskKill(string imageName)
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
					$"taskkill /F /IM {imageName}"
				);
				LogHelper.Write(LogHelper.Type_Debug, $"Execute: taskkill /F /IM \"{imageName}\"");
			}
			else
			{
				LogHelper.Write(LogHelper.Type_Error, "Non-supported operation system.");
			}
		}
	}
}
