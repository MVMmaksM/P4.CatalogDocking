using OfficeOpenXml;
using P4.CatalogDocking.Models;
using P4.CatalogDocking.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class ReportingWork : IWorkFile<ReportingModel>
    {
        public List<ReportingModel> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p1ReportMonthData = new List<ReportingModel>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var dataFromReport = new ReportingModel
                    (
                    okpo: row[i, 1].Text,
                    okpoUl: row[i, 2].Text,
                    name: row[i, 3].Text,
                    okfs: Convert.ToByte(row[i, 4].Text),
                    kies: Convert.ToInt16(row[i, 5].Text),
                    okato: Convert.ToInt64(row[i, 6].Text),
                    okogu: Convert.ToInt32(row[i, 7].Text),
                    okopf: Convert.ToInt32(row[i, 8].Text),
                    oktmo: Convert.ToInt64(row[i, 9].Text),
                    typPred: Convert.ToByte(row[i, 10].Text),
                    okvedHoz: row[i,11].Text                   
                    );

                p1ReportMonthData.Add(dataFromReport);
            }

            return p1ReportMonthData;
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {            
            var pathDirectory = Directory.GetParent(pathSaveFile)?.FullName;       

            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            File.WriteAllBytes(pathSaveFile, bytesFile);
        }
    }
}
