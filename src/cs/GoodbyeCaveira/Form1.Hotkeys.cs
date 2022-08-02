using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GoodbyeCaveira.Lib.Utilities;

namespace GoodbyeCaveira
{
    public partial class Form1
    {
		#region ===Action===
		public static readonly User32.KeyModifiers DefaultKeyModifiers_Action = User32.KeyModifiers.Ctrl | User32.KeyModifiers.Shift;
        public static readonly Keys DefaultHotKey_Action = Keys.Q;

        private User32.KeyModifiers hotKeyModifiers_Action;
        private Keys hotKey_Action;
        private string hotKeyName_Action;

        private static readonly string HotKey_Action_Name = "Action";
        private Message HotKey_Action(Message message)
        {
            this.BeginInvoke((Action)(() =>
            {
                Action();
            }));
            return message;
        }

        private void CleanHotKeyInfo_Action()
        {
            hotKeyModifiers_Action = User32.KeyModifiers.None;
            hotKey_Action = Keys.None;
            Change_textBox_SetSwitchHotKey_Text(GetHotKeyName());
        }

        private void button_BindActionHotKey_Click(object sender, EventArgs e)
        {
            var sameName = from val in HotKeyManager.HotKeyInfos
                           where val.Name == HotKey_Action_Name
                           select val;
            if (sameName.Count() > 0)
            {
                if (hotKey_Action == Keys.None)
                {
                    HotKeyManager.Remove(HotKey_Action_Name);
                }
                else
                {
                    try
                    {
                        HotKeyManager.Change(HotKey_Action_Name, hotKeyModifiers_Action, hotKey_Action, this, HotKey_Action);
                    }
                    catch (Exception)
                    {
                        HotKeyInfo last = sameName.Single();
                        textBox_ActionHotKey.Text = GetHotKeyName(last.KeyModifiers, last.Key);

                        Utility.ShowWarning("注册热键失败。");
                        return;
                    }
                }
            }
            else
            {
                if (hotKey_Action != Keys.None)
                {
                    try
                    {
                        HotKeyManager.Add(HotKey_Action_Name, hotKeyModifiers_Action, hotKey_Action, this, HotKey_Action);
                    }
                    catch (Exception)
                    {
                        CleanHotKeyInfo_Action();

                        Utility.ShowWarning("注册热键失败。");
                        return;
                    }
                }
            }
            Change_textBox_SetSwitchHotKey_Text(GetHotKeyName(hotKeyModifiers_Action, hotKey_Action));
        }

        private void textBox_ActionHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                CleanHotKeyInfo_Action();
                e.Handled = true;
                return;
            }

            hotKeyModifiers_Action = User32.KeyModifiers.None;
            if (e.Alt && e.KeyCode != Keys.Menu)
            {
                hotKeyModifiers_Action |= User32.KeyModifiers.Alt;
            }
            if (e.Control && e.KeyCode != Keys.ControlKey)
            {
                hotKeyModifiers_Action |= User32.KeyModifiers.Ctrl;
            }
            if (e.Shift && e.KeyCode != Keys.ShiftKey)
            {
                hotKeyModifiers_Action |= User32.KeyModifiers.Shift;
            }
            hotKey_Action = e.KeyCode;

            Change_textBox_SetSwitchHotKey_Text(GetHotKeyName(hotKeyModifiers_Action, hotKey_Action));

            e.Handled = true;
        }

        private void Change_textBox_SetSwitchHotKey_Text(string text)
        {
            textBox_ActionHotKey.Text = hotKeyName_Action = text;
        }
        private void textBox_SetSwitchHotKey_TextChanged(object sender, EventArgs e)
        {
            textBox_ActionHotKey.Text = hotKeyName_Action;
        }
        #endregion

        public static string GetHotKeyName()
        {
            return GetHotKeyName(User32.KeyModifiers.None, Keys.None);
        }
        public static string GetHotKeyName(User32.KeyModifiers keyModifier, Keys key)
        {
            if (key == Keys.None)
            {
                return "<null>";
            }

            StringBuilder name = new StringBuilder("");
            if ((keyModifier & User32.KeyModifiers.Alt) == User32.KeyModifiers.Alt)
            {
                name.Append("Alt + ");
            }
            if ((keyModifier & User32.KeyModifiers.Ctrl) == User32.KeyModifiers.Ctrl)
            {
                name.Append("Ctrl + ");
            }
            if ((keyModifier & User32.KeyModifiers.Shift) == User32.KeyModifiers.Shift)
            {
                name.Append("Shift + ");
            }

            name.Append(Enum.GetName(typeof(Keys), key));

            return name.ToString();
        }

        private void InitHotKey()
        {
            try
            {
                HotKeyManager.Add(HotKey_Action_Name, DefaultKeyModifiers_Action, DefaultHotKey_Action, this, HotKey_Action);
            }
            catch (Exception)
            {
                Utility.ShowWarning("默认热键注册失败。可能会影响使用，请更改热键设置。");
                CleanHotKeyInfo_Action();
                return;
            }
            Change_textBox_SetSwitchHotKey_Text(GetHotKeyName(DefaultKeyModifiers_Action, DefaultHotKey_Action));
        }
    }
}
