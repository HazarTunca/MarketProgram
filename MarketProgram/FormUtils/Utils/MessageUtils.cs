using System;
using System.Windows.Forms;

namespace XIV.Utils
{
    public static class MessageUtils
    {
        public static MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button1;

        public DialogResult Show(string title, string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return MessageBox.Show(title, message, messageBoxButtons, icon, defaultButton);
        }

        public DialogResult ShowInfo(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultButton);
        }

        public DialogResult ShowWarning(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Warning, DefaultButton);
        }

        public DialogResult ShowError(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultButton);
        }

        public static class YesNoFeedback
        {
            public DialogResult ShowInfo(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Information, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return;
                }
                noAction?.Invoke();

                return result;
            }

            public DialogResult ShowWarning(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return;
                }
                noAction?.Invoke();

                return result;
            }

            public DialogResult ShowError(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Error, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return;
                }
                noAction?.Invoke();

                return result;
            }
        }

        public static class YesNoCancelFeedback
        {
            public DialogResult ShowInfo(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result = DialogResult.No)
                {
                    noAction?.Invoke();
                }
                else
                {
                    cancelAction?.Invoke();
                }

                return result;
            }

            public DialogResult ShowWarning(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result = DialogResult.No)
                {
                    noAction?.Invoke();
                }
                else
                {
                    cancelAction?.Invoke();
                }

                return result;
            }

            public DialogResult ShowError(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result = DialogResult.No)
                {
                    noAction?.Invoke();
                }
                else
                {
                    cancelAction?.Invoke();
                }

                return result;
            }
        }
    }
}
