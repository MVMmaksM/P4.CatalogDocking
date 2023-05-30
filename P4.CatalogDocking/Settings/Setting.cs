using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Settings
{
    public static class Setting
    {
        private static string _pathSaveFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{DateTime.Now.ToShortDateString()}_сверка" );
        public static string GetFolderPath() => _pathSaveFile;
    }
}
