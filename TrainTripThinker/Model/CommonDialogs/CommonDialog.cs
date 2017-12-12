using System;

using Microsoft.Win32;

namespace TrainTripThinker.Model
{
    public static class CommonDialog
    {
        public static string ChooseOpenFile()
        {
            FileDialog dialog = InitializeDialog(new OpenFileDialog());
            bool? result = dialog.ShowDialog();

            return result.Value ? dialog.FileName : null;
        }

        public static string ChooseSaveFile()
        {
            FileDialog dialog = InitializeDialog(new SaveFileDialog());
            bool? result = dialog.ShowDialog();

            return result.Value ? dialog.FileName : null;
        }

        private static FileDialog InitializeDialog(FileDialog dialog)
        {
            if (dialog == null)
            {
                throw new ArgumentNullException(nameof(dialog));
            }

            dialog.FilterIndex = 1;
            dialog.Filter = Properties.Settings.Default.ExtensionFilter;

            return dialog;

        }
    }
}