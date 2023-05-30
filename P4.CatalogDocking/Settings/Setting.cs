using P4.CatalogDocking.Models;
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
        private static string _pathSaveFile;
        public static string GetFolderPath() => _pathSaveFile;
        public static void SetSetting(SettingModel settingModel) 
        {
            _pathSaveFile = settingModel.pathSaveFileResult;
        }
    }
}
