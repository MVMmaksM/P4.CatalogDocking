using OfficeOpenXml;
using P4.CatalogDocking.Exceptions;
using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P4.CatalogDocking.Services
{
    public class CatalogWork : IWorkFile<CatalogModel>
    {
        private IHandleException _handleException;
        public CatalogWork(IHandleException handleException)
        {
            _handleException = handleException;   
        }

        public List<CatalogModel> Read(string pathFile)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelPackage = new ExcelPackage(pathFile);
            var excelSheet = excelPackage.Workbook.Worksheets[0];

            var endColumn = excelSheet.Dimension.End.Column;
            var endRow = excelSheet.Dimension.End.Row;

            var p4CatalogMonthData = new List<CatalogModel>();

            try
            {
                for (int i = 2; i <= endRow; i++)
                {
                    var row = excelSheet.Cells[i, 1, i, endColumn];
                    var dataFromCatalog = new CatalogModel
                        (
                        okpo: string.IsNullOrWhiteSpace(row[i, 1].Text) ? throw new OkpoNullException(i) : row[i, 1].Text,
                        okpoUl: row[i, 2].Text,
                        name: row[i, 3].Text,
                        okato: string.IsNullOrWhiteSpace(row[i, 4].Text) ? throw new OkatoNullException(i) : Convert.ToInt64(row[i, 4].Text),
                        okvedFact: string.IsNullOrWhiteSpace(row[i, 5].Text) ? throw new OkvedNullException(i) : row[i, 5].Text,
                        typPred: string.IsNullOrWhiteSpace(row[i, 6].Text) ? throw new TypPredNullException(i) : Convert.ToByte(row[i, 6].Text),
                        okfs: string.IsNullOrWhiteSpace(row[i, 7].Text) ? null : Convert.ToByte(row[i, 7].Text),
                        okopf: string.IsNullOrWhiteSpace(row[i, 8].Text) ? null : Convert.ToInt32(row[i, 8].Text),
                        okogu: string.IsNullOrWhiteSpace(row[i, 9].Text) ? null : Convert.ToInt32(row[i, 9].Text),
                        typActual: string.IsNullOrWhiteSpace(row[i, 10].Text) ? null : Convert.ToByte(row[i, 10].Text),
                        kies: string.IsNullOrWhiteSpace(row[i, 11].Text) ? null : Convert.ToInt16(row[i, 11].Text),
                        oktmo: string.IsNullOrWhiteSpace(row[i, 12].Text) ? null : Convert.ToInt64(row[i, 12].Text)
                        );

                    p4CatalogMonthData.Add(dataFromCatalog);
                }
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
            }

            return p4CatalogMonthData;
        }


        public void SaveFile(byte[] bytesFile, string pathSaveFile)
        {
            throw new NotImplementedException();
        }
    }
}
