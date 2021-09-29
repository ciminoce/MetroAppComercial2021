using System;
using System.Windows.Forms;
using MetroFramework;

namespace MetroAppComercial2021.Windows.Helpers
{
    public static class HelperMessageBox
    {
        public static void Message(Form owner,string message, string title, MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Information:
                    MetroMessageBox.Show(owner, message, title, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case MessageType.Error:
                    MetroMessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageType.Warning:
                    MetroMessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(messageType), messageType, null);
            }
        }

        public static DialogResult Message(Form owner, string message, string title)
        {
            return MetroMessageBox.Show(owner, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }
    }
}
