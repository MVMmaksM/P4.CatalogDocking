using OfficeOpenXml;
using P4.CatalogDocking.Models.P4.Quarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class P4ReportQuarterWork : IWorkFile<P4ReportQuarter>
    {
        public List<P4ReportQuarter> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p4ReportQuarterData = new List<P4ReportQuarter>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var p4ReportQuarter = new P4ReportQuarter
                    (
                    okpo: row[i, 1].Text,
                    okpoUl: row[i, 2].Text,
                    name: row[i, 3].Text,
                    okfs: row[i, 4].Text,
                    kies: row[i, 5].Text,
                    okato: row[i, 6].Text,
                    okogu: row[i, 7].Text,
                    okopf: row[i, 8].Text,
                    okvedHoz: row[i, 9].Text,
                    typPred: row[i, 10].Text
                    );

                p4ReportQuarterData.Add(p4ReportQuarter);
            }

            return p4ReportQuarterData;
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
