using Newtonsoft.Json;
using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class SettingService : IWorkFile<SettingModel>
    {
        public List<SettingModel> Read(string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                CreateFileSetting(pathFile);
            }
            string settings = string.Empty;

            using (var reader = new StreamReader(pathFile))
            {
                settings = reader.ReadToEnd();
            }

            return new List<SettingModel>() { JsonConvert.DeserializeObject<SettingModel>(settings) };
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            File.WriteAllBytes(pathSaveFile, bytesFile);
        }

        private void CreateFileSetting(string pathFile)
        {
            var setting = new SettingModel()
            {
                pathSaveFileResult = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{DateTime.Now.ToShortDateString()}_сверка")

            };

            var serializeSetting = JsonConvert.SerializeObject(setting);

            using (var writer = new StreamWriter(pathFile))
            {
                writer.Write(serializeSetting);
            }
        }
    }
}
