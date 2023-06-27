using OfficeOpenXml;
using P4.CatalogDocking.Exceptions;
using P4.CatalogDocking.Models;
using P4.CatalogDocking.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P4.CatalogDocking.Services
{
    public class ReportingWork : IWorkFile<ReportingModel>
    {
        private IHandleException _handleException;
        public ReportingWork(IHandleException handleException)
        {
            _handleException = handleException;
        }
        public List<ReportingModel> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p1ReportMonthData = new List<ReportingModel>();

            try
            {
                for (int i = 2; i <= endRow; i++)
                {
                    var row = excelSheet.Cells[i, 1, i, endColumn];
                    var dataFromReport = new ReportingModel
                        (
                        okpo: string.IsNullOrWhiteSpace(row[i, 1].Text) ? throw new OkpoNullException(i) : row[i, 1].Text,
                        okpoUl: row[i, 2].Text,
                        name: row[i, 3].Text,
                        okfs: string.IsNullOrWhiteSpace(row[i, 4].Text) ? null : Convert.ToByte(row[i, 4].Text),
                        kies: string.IsNullOrWhiteSpace(row[i, 5].Text) ? null : Convert.ToInt16(row[i, 5].Text),
                        okato: string.IsNullOrWhiteSpace(row[i, 6].Text) ? throw new OkatoNullException(i) : Convert.ToInt64(row[i, 6].Text),
                        okogu: string.IsNullOrWhiteSpace(row[i, 7].Text) ? null : Convert.ToInt32(row[i, 7].Text),
                        okopf: string.IsNullOrWhiteSpace(row[i, 8].Text) ? null : Convert.ToInt32(row[i, 8].Text),
                        oktmo: string.IsNullOrWhiteSpace(row[i, 9].Text) ? null : Convert.ToInt64(row[i, 9].Text),
                        okvedHoz: string.IsNullOrWhiteSpace(row[i, 10].Text) ? throw new OkvedNullException(i) : row[i, 10].Text,
                        typPred: string.IsNullOrWhiteSpace(row[i, 11].Text) ? throw new TypPredNullException(i) : Convert.ToByte(row[i, 11].Text)
                        );

                    p1ReportMonthData.Add(dataFromReport);
                }
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
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
