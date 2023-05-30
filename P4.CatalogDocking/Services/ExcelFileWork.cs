using OfficeOpenXml;
using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class ExcelFileWork
    {
        private static ExcelPackage CreateExcelCatalogModel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("Лист 1");

            sheet.Cells[1, 1].Value = "ОКПО";
            sheet.Cells[1, 2].Value = "ОКПО ЮЛ";
            sheet.Cells[1, 3].Value = "Краткое наименование объекта / Краткое наименование";
            sheet.Cells[1, 4].Value = "ОКФС";
            sheet.Cells[1, 5].Value = "КИЕС";
            sheet.Cells[1, 6].Value = "ОКАТО факт.";
            sheet.Cells[1, 7].Value = "Код ОКОГУ";
            sheet.Cells[1, 8].Value = "ОКОПФ";
            sheet.Cells[1, 9].Value = "ОКТМО";
            sheet.Cells[1, 10].Value = "Тип предприятия";
            sheet.Cells[1, 11].Value = "Факт.ОКВЭД2: Основной в.д.";
            sheet.Cells[1, 12].Value = "Тип актуализации";

            return package;
        }

        private static ExcelPackage CreateExcelReportingModel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("Лист 1");

            sheet.Cells[1, 1].Value = "ОКПО";
            sheet.Cells[1, 2].Value = "ОКПО ЮЛ";
            sheet.Cells[1, 3].Value = "Краткое наименование объекта / Краткое наименование";
            sheet.Cells[1, 4].Value = "ОКФС";
            sheet.Cells[1, 5].Value = "КИЕС";
            sheet.Cells[1, 6].Value = "ОКАТО факт.";
            sheet.Cells[1, 7].Value = "Код ОКОГУ";
            sheet.Cells[1, 8].Value = "ОКОПФ";
            sheet.Cells[1, 9].Value = "ОКТМО";
            sheet.Cells[1, 10].Value = "Тип предприятия";
            sheet.Cells[1, 11].Value = "Хоз.ОКВЭД2: Основной в.д.";

            return package;
        }

        private static ExcelPackage CreateExcelResultDockingCatalog()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("Лист 1");

            sheet.Cells[1, 1, 1, 12].Merge = true;
            sheet.Cells[1, 1, 1, 12].Value = "Текущий период";
            sheet.Cells[1, 1, 1, 12].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            sheet.Cells[2, 1].Value = "ОКПО";
            sheet.Cells[2, 2].Value = "ОКПО ЮЛ";
            sheet.Cells[2, 3].Value = "Краткое наименование объекта / Краткое наименование";
            sheet.Cells[2, 4].Value = "ОКФС";
            sheet.Cells[2, 5].Value = "КИЕС";
            sheet.Cells[2, 6].Value = "ОКАТО факт.";
            sheet.Cells[2, 7].Value = "Код ОКОГУ";
            sheet.Cells[2, 8].Value = "ОКОПФ";
            sheet.Cells[2, 9].Value = "ОКТМО";
            sheet.Cells[2, 10].Value = "Тип предприятия";
            sheet.Cells[2, 11].Value = "Факт.ОКВЭД2: Основной в.д.";
            sheet.Cells[2, 12].Value = "Тип актуализации";

            sheet.Cells[1, 13, 1, 25].Merge = true;
            sheet.Cells[1, 13, 1, 25].Value = "Предыдущий период";
            sheet.Cells[1, 13, 1, 25].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            sheet.Cells[2, 13].Value = "ОКПО";
            sheet.Cells[2, 14].Value = "ОКПО ЮЛ";
            sheet.Cells[2, 15].Value = "Краткое наименование объекта / Краткое наименование";
            sheet.Cells[2, 16].Value = "ОКФС";
            sheet.Cells[2, 17].Value = "КИЕС";
            sheet.Cells[2, 18].Value = "ОКАТО факт.";
            sheet.Cells[2, 19].Value = "Код ОКОГУ";
            sheet.Cells[2, 20].Value = "ОКОПФ";
            sheet.Cells[2, 21].Value = "ОКТМО";
            sheet.Cells[2, 22].Value = "Тип предприятия";
            sheet.Cells[2, 23].Value = "Факт.ОКВЭД2: Основной в.д.";
            sheet.Cells[2, 24].Value = "Тип актуализации";

            return package;
        }
        public static byte[] GetExcelFromList(List<BaseModel> resultDockingCatalog)
        {
            if (resultDockingCatalog.Count == 0)
            {
                var package = new ExcelPackage();
                package.Workbook.Worksheets.Add("Лист 1");
                return package.GetAsByteArray();
            }

            var dataFromCatalog = resultDockingCatalog[0];
            ExcelPackage excelPackage = new ExcelPackage();

            if (dataFromCatalog is CatalogModel)
            {
                excelPackage = CreateExcelCatalogModel();
                var sheet = excelPackage.Workbook.Worksheets[0];

                for (int i = 0; i < resultDockingCatalog.Count; i++)
                {
                    var row = resultDockingCatalog[i] as CatalogModel;

                    sheet.Cells[i + 2, 1].Value = row?.Okpo;
                    sheet.Cells[i + 2, 2].Value = row?.OkpoUl;
                    sheet.Cells[i + 2, 3].Value = row?.Name;
                    sheet.Cells[i + 2, 4].Value = row?.Okfs;
                    sheet.Cells[i + 2, 5].Value = row?.Kies;
                    sheet.Cells[i + 2, 6].Value = row?.OkatoFact;
                    sheet.Cells[i + 2, 7].Value = row?.Okogu;
                    sheet.Cells[i + 2, 8].Value = row?.Okopf;
                    sheet.Cells[i + 2, 9].Value = row?.Oktmo;
                    sheet.Cells[i + 2, 10].Value = row?.TypPred;
                    sheet.Cells[i + 2, 11].Value = row?.OkvedFact;
                    sheet.Cells[i + 2, 12].Value = row?.TypActual;
                }
            }
            else if (dataFromCatalog is ReportingModel)
            {
                excelPackage = CreateExcelReportingModel();
                var sheet = excelPackage.Workbook.Worksheets[0];

                for (int i = 0; i < resultDockingCatalog.Count; i++)
                {
                    var row = resultDockingCatalog[i] as ReportingModel;

                    sheet.Cells[i + 2, 1].Value = row?.Okpo;
                    sheet.Cells[i + 2, 2].Value = row?.OkpoUl;
                    sheet.Cells[i + 2, 3].Value = row?.Name;
                    sheet.Cells[i + 2, 4].Value = row?.Okfs;
                    sheet.Cells[i + 2, 5].Value = row?.Kies;
                    sheet.Cells[i + 2, 6].Value = row?.OkatoFact;
                    sheet.Cells[i + 2, 7].Value = row?.Okogu;
                    sheet.Cells[i + 2, 8].Value = row?.Okopf;
                    sheet.Cells[i + 2, 9].Value = row?.Oktmo;
                    sheet.Cells[i + 2, 10].Value = row?.TypPred;
                    sheet.Cells[i + 2, 11].Value = row?.OkvedHoz;
                }
            }

            return excelPackage.GetAsByteArray();
        }

        public static byte[] GetExcelFromList(List<ResultDockingCatalog> resultDockingCatalog, int columnFromColorCur, int columnFromColorPrev)
        {         
            if (resultDockingCatalog.Count == 0)
            {
                var package = new ExcelPackage();
                package.Workbook.Worksheets.Add("Лист 1");
                return package.GetAsByteArray();
            }

            var excelPackage = CreateExcelResultDockingCatalog();
            var sheet = excelPackage.Workbook.Worksheets[0];

            for (int i = 0; i < resultDockingCatalog.Count; i++)
            {
                sheet.Cells[i + 3, 1].Value = resultDockingCatalog[i].Okpo;
                sheet.Cells[i + 3, 2].Value = resultDockingCatalog[i].OkpoUl;
                sheet.Cells[i + 3, 3].Value = resultDockingCatalog[i].Name;
                sheet.Cells[i + 3, 4].Value = resultDockingCatalog[i].Okfs;
                sheet.Cells[i + 3, 5].Value = resultDockingCatalog[i].Kies;
                sheet.Cells[i + 3, 6].Value = resultDockingCatalog[i].OkatoFact;
                sheet.Cells[i + 3, 7].Value = resultDockingCatalog[i].Okogu;
                sheet.Cells[i + 3, 8].Value = resultDockingCatalog[i].Okopf;
                sheet.Cells[i + 3, 9].Value = resultDockingCatalog[i].Oktmo;
                sheet.Cells[i + 3, 10].Value = resultDockingCatalog[i].TypPred;
                sheet.Cells[i + 3, 11].Value = resultDockingCatalog[i].OkvedFact;
                sheet.Cells[i + 3, 12].Value = resultDockingCatalog[i].TypActual;
                sheet.Cells[i + 3, 13].Value = resultDockingCatalog[i].PrevOkpo;
                sheet.Cells[i + 3, 14].Value = resultDockingCatalog[i].OkpoUl;
                sheet.Cells[i + 3, 15].Value = resultDockingCatalog[i].Name;
                sheet.Cells[i + 3, 16].Value = resultDockingCatalog[i].Okfs;
                sheet.Cells[i + 3, 17].Value = resultDockingCatalog[i].Kies;
                sheet.Cells[i + 3, 18].Value = resultDockingCatalog[i].OkatoFact;
                sheet.Cells[i + 3, 19].Value = resultDockingCatalog[i].Okogu;
                sheet.Cells[i + 3, 20].Value = resultDockingCatalog[i].Okopf;
                sheet.Cells[i + 3, 21].Value = resultDockingCatalog[i].Oktmo;
                sheet.Cells[i + 3, 22].Value = resultDockingCatalog[i].TypPred;
                sheet.Cells[i + 3, 23].Value = resultDockingCatalog[i].OkvedFact;
                sheet.Cells[i + 3, 24].Value = resultDockingCatalog[i].TypActual;
            }

            var toRowEnd = resultDockingCatalog.Count;
            sheet.Cells[3, columnFromColorCur, 2 + toRowEnd, columnFromColorCur].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            sheet.Cells[3, columnFromColorCur, 2 + toRowEnd, columnFromColorCur].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
            sheet.Cells[3, columnFromColorPrev, 2 + toRowEnd, columnFromColorPrev].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            sheet.Cells[3, columnFromColorPrev, 2 + toRowEnd, columnFromColorPrev].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);

            return excelPackage.GetAsByteArray();
        }
    }
}
