using System;
using System.Windows.Forms;

namespace XIV.Utils
{
    public static class MessageUtils
    {
        public static MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button1;

        public static DialogResult Show(string title, string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return MessageBox.Show(message, title, messageBoxButtons, icon, defaultButton);
        }

        public static DialogResult ShowInfo(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultButton);
        }

        public static DialogResult ShowWarning(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Warning, DefaultButton);
        }

        public static DialogResult ShowError(string title, string message)
        {
            return Show(title, message, MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultButton);
        }

        public static class YesNoFeedback
        {
            public static DialogResult ShowInfo(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Information, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return result;
                }
                noAction?.Invoke();

                return result;
            }

            public static DialogResult ShowWarning(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return result;
                }
                noAction?.Invoke();

                return result;
            }

            public static DialogResult ShowError(string title, string message, Action yesAction, Action noAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNo, MessageBoxIcon.Error, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                    return result;
                }
                noAction?.Invoke();

                return result;
            }
        }

        public static class YesNoCancelFeedback
        {
            public static DialogResult ShowInfo(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result == DialogResult.No)
                {
                    noAction?.Invoke();
                }
                else
                {
                    cancelAction?.Invoke();
                }

                return result;
            }

            public static DialogResult ShowWarning(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result == DialogResult.No)
                {
                    noAction?.Invoke();
                }
                else
                {
                    cancelAction?.Invoke();
                }

                return result;
            }

            public static DialogResult ShowError(string title, string message, Action yesAction, Action noAction, Action cancelAction)
            {
                var result = Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, DefaultButton);
                if (result == DialogResult.Yes)
                {
                    yesAction?.Invoke();
                }
                else if (result == DialogResult.No)
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
