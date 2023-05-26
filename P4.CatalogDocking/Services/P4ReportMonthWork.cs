using OfficeOpenXml;
using P4.CatalogDocking.Models.P1.Month;
using P4.CatalogDocking.Models.P4.Month;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class P4ReportMonthWork : IWorkFile<P4ReportMonth>
    {
        public List<P4ReportMonth> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p4ReportMonthData = new List<P4ReportMonth>();

            for (int i = 2; i <= endRow; i++)
            {
                var row = excelSheet.Cells[i, 1, i, endColumn];
                var p4ReportMonth = new P4ReportMonth
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
                    typPred: row[i, 11].Text
                    );

                p4ReportMonthData.Add(p4ReportMonth);
            }

            return p4ReportMonthData;
        }

        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
