using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P4.CatalogDocking.Views
{
    public class FileDialog
    {
        public static string? ShowFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.xlsx|*.xlsx";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var pathFile = string.Empty;

            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : null;
        }
    }
}



