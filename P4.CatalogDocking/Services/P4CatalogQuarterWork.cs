using OfficeOpenXml;
using P4.CatalogDocking.Models.P4.Month;
using P4.CatalogDocking.Models.P4.Quarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class P4CatalogQuarterWork : IWorkFile<P4CatalogQuarter>
    {
        public List<P4CatalogQuarter> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p4CatalogQuarterData = new List<P4CatalogQuarter>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var p4CatalogQuarter = new P4CatalogQuarter
                    (
                    okpo: row[i, 1].Text,
                    okpoUl: row[i, 2].Text,
                    name: row[i, 3].Text,
                    okatoFact: row[i, 4].Text,
                    okvedFact: row[i, 5].Text,
                    typPred: row[i, 6].Text,
                    okfs: row[i, 7].Text,
                    okopf: row[i, 8].Text,
                    okogu: row[i, 9].Text,
                    typActual: row[i, 10].Text                   
                    );

                p4CatalogQuarterData.Add(p4CatalogQuarter);
            }

            return p4CatalogQuarterData;
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
