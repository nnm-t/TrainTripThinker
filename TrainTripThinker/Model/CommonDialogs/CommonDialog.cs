using System;

using Microsoft.Win32;

namespace TrainTripThinker.Model
{
    public static class CommonDialog
    {
        public static string ChooseOpenFile(ExtensionFilter filter)
        {
            FileDialog dialog = InitializeDialog(new OpenFileDialog(), filter);
            bool? result = dialog.ShowDialog();

            return result.Value ? dialog.FileName : null;
        }

        public static string ChooseSaveFile(ExtensionFilter filter)
        {
            FileDialog dialog = InitializeDialog(new SaveFileDialog(), filter);
            bool? result = dialog.ShowDialog();

            return result.Value ? dialog.FileName : null;
        }

        private static FileDialog InitializeDialog(FileDialog dialog, ExtensionFilter filter, int filterIndex = 1)
        {
            if (dialog == null)
            {
                throw new ArgumentNullException(nameof(dialog));
            }

            dialog.Filter = filter.FilterString;
            dialog.FilterIndex = filterIndex;

            return dialog;

        }
    }
}