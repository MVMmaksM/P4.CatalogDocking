using OfficeOpenXml;
using P4.CatalogDocking.Models.P4.Quarter;
using P4.CatalogDocking.Models.P5.Quarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class P5ReportQuarterWork : IWorkFile<P5ReportQuarter>
    {
        public List<P5ReportQuarter> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p5ReportQuarterData = new List<P5ReportQuarter>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var p5ReportQuarter = new P5ReportQuarter
                    (
                    okpo: row[i, 1].Text,
                    okpoUl: row[i, 2].Text,
                    name: row[i, 3].Text,
                    okfs: row[i, 4].Text,
                    kies: row[i, 5].Text,
                    okato: row[i, 6].Text,
                    okogu: row[i, 7].Text,
                    okopf: row[i, 8].Text,
                    oktmo: row[i, 9].Text,
                    okvedHoz: row[i, 10].Text,
                    typPred: row[i, 10].Text
                    );

                p5ReportQuarterData.Add(p5ReportQuarter);
            }

            return p5ReportQuarterData;
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
