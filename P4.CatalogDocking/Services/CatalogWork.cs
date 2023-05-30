using OfficeOpenXml;
using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class CatalogWork : IWorkFile<CatalogModel>
    {
        public List<CatalogModel> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p4CatalogMonthData = new List<CatalogModel>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var dataFromCatalog = new CatalogModel
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
                    okvedFact: row[i, 11].Text,
                    typActual: Convert.ToByte(row[i, 12].Text)
                    );

                p4CatalogMonthData.Add(dataFromCatalog);
            }

            return p4CatalogMonthData;
        }


        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
