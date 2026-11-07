using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Global_Classes
{
    internal static class clsMessageBox
    {
        public static DialogResult ShowError(string Message, string Title = "Error")
        {
            return MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowWarning(string Message, string Title = "Warning", 
            MessageBoxButtons MsgBoxButtons = MessageBoxButtons.OKCancel)
        {
            return MessageBox.Show(Message, "Warning", MsgBoxButtons, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowInfo(string Message, string Title = "Success")
        {
            return MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowValidationError()
        {
            return ShowError(
                "Some fields are not valid! put the mouse over the red icon(s) to see the error",
                "Validation Error");
        }

        public static bool ShowConfirmQuestion(string Message, string Title = "Confirm")
        {
            return MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

    }
}
