using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodbyeCaveira.Lib.Utilities
{
	public class Utility
	{
        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error 错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        public static void ShowWarning(string text)
        {
            MessageBox.Show(text, "Warning 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
        public static void ShowInformation(string text)
        {
            MessageBox.Show(text, "Information 信息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
