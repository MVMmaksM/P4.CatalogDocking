using Newtonsoft.Json;
using P4.CatalogDocking.Comparator;
using P4.CatalogDocking.Exceptions;
using P4.CatalogDocking.Models;
using P4.CatalogDocking.Services;
using P4.CatalogDocking.Settings;
using P4.CatalogDocking.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace P4.CatalogDocking
{
    public class Facade
    {
        private IMessage _message;
        private IHandleException _handleException;

        private List<CatalogModel> p4CatalogCurMonth = new List<CatalogModel>();
        private List<CatalogModel> p4CatalogPrevMonth = new List<CatalogModel>();
        private List<ReportingModel> p4ReportPrevMonth = new List<ReportingModel>();
        private List<CatalogModel> p4CatalogCurQuarter = new List<CatalogModel>();
        private List<CatalogModel> p4CatalogPrevQuarter = new List<CatalogModel>();
        private List<ReportingModel> p4ReportPrevQuarter = new List<ReportingModel>();
        private List<ReportingModel> p1ReportPrevMonth = new List<ReportingModel>();
        private List<ReportingModel> p5ReportPrevQuarter = new List<ReportingModel>();

        string p4CatalogCurMonthFileName = string.Empty;
        string p4CatalogPrevMonthFileName = string.Empty;
        string p4ReportPrevMonthFileName = string.Empty;
        string p4CatalogCurQuarterFileName = string.Empty;
        string p4CatalogPrevQuarterFileName = string.Empty;
        string p4ReportPrevQuarterFileName = string.Empty;
        string p1ReportPrevMonthFileName = string.Empty;
        string p5ReportPrevQuarterfileName = string.Empty;

        private string _pathFileSettings = Path.Combine(Environment.CurrentDirectory, "appSettings.json");

        public Facade(IHandleException handleException, IMessage message)
        {
            _message = message;
            _handleException = handleException;
        }

        public string LoadP4CatCurMonth()
        {
            try
            {
                var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4CatalogCurMonth = loadCatalogServices.Read(pathFile);
                    p4CatalogCurMonthFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4CatalogCurMonth.Count, p4CatalogCurMonthFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP4CatPrevMonth()
        {
            try
            {
                var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4CatalogPrevMonth = loadCatalogServices.Read(pathFile);
                    p4CatalogPrevMonthFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4CatalogPrevMonth.Count, p4CatalogPrevMonthFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP4RepPrevMonth()
        {
            try
            {
                var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4ReportPrevMonth = loadCatalogServices.Read(pathFile);
                    p4ReportPrevMonthFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4ReportPrevMonth.Count, p4ReportPrevMonthFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP1RepPrevMonth()
        {
            try
            {
                var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p1ReportPrevMonth = loadCatalogServices.Read(pathFile);
                    p1ReportPrevMonthFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p1ReportPrevMonth.Count, p1ReportPrevMonthFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP4CatCurQuart()
        {
            try
            {
                var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4CatalogCurQuarter = loadCatalogServices.Read(pathFile);
                    p4CatalogCurQuarterFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4CatalogCurQuarter.Count, p4CatalogCurQuarterFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP4CatPrevQuart()
        {
            try
            {
                var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4CatalogPrevQuarter = loadCatalogServices.Read(pathFile);
                    p4CatalogPrevQuarterFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4CatalogPrevQuarter.Count, p4CatalogPrevQuarterFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP4RepPrevQuart()
        {
            try
            {
                var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p4ReportPrevQuarter = loadCatalogServices.Read(pathFile);
                    p4ReportPrevQuarterFileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p4ReportPrevQuarter.Count, p4ReportPrevQuarterFileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public string LoadP5RepPrevQuart()
        {
            try
            {
                var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                var pathFile = FileDialog.ShowFileDialog();

                if (pathFile is not null)
                {
                    p5ReportPrevQuarter = loadCatalogServices.Read(pathFile);
                    p5ReportPrevQuarterfileName = Path.GetFileNameWithoutExtension(pathFile);
                    return StringCount.GetStringCountLoad(p5ReportPrevQuarter.Count, p5ReportPrevQuarterfileName);
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
                return string.Empty;
            }
        }

        public void DockingCatalogsMonth()
        {
            try
            {
                if (p4CatalogCurMonth.Count != 0 && p4CatalogPrevMonth.Count != 0 && p1ReportPrevMonth.Count != 0 && p4ReportPrevMonth.Count != 0)
                {
                    var exceptCurPrev = CatalogComparator.ExceptCatalog(p4CatalogCurMonth.ToList<BaseModel>(), p4CatalogPrevMonth.ToList<BaseModel>());
                    var exceptPrevCur = CatalogComparator.ExceptCatalog(p4CatalogPrevMonth.ToList<BaseModel>(), p4CatalogCurMonth.ToList<BaseModel>());
                    var exceptCurP4RepP4 = CatalogComparator.ExceptCatalog(p4ReportPrevMonth.ToList<BaseModel>(), p4CatalogCurMonth.ToList<BaseModel>());
                    var exceptCurP4RepP1 = CatalogComparator.ExceptCatalog(p1ReportPrevMonth.ToList<BaseModel>(), p4CatalogCurMonth.ToList<BaseModel>());
                    var liquidatedOrganizations = CatalogComparator.GetLiquidatedOrganization(p4CatalogCurMonth);
                    var dockingOkved = CatalogComparator.GetDockingCatalog(p4CatalogCurMonth, p4CatalogPrevMonth, a => a.OkvedFact != a.PrevOkvedFact);
                    var dockingOkato = CatalogComparator.GetDockingCatalog(p4CatalogCurMonth, p4CatalogPrevMonth, a => a.OkatoFact != a.PrevOkatoFact);

                    var fullNameExceptP4CurPrev = FileName.GetFullNameExceptP4(p4CatalogCurMonthFileName, p4CatalogPrevMonthFileName);
                    var fullNameExceptP4PrevCur = FileName.GetFullNameExceptP4(p4CatalogPrevMonthFileName, p4CatalogCurMonthFileName);
                    var fullNameExcRepP1 = FileName.GetFullNameExcRep(p1ReportPrevMonthFileName, p4CatalogCurMonthFileName);
                    var fullNameExcRepP4 = FileName.GetFullNameExcRep(p4ReportPrevMonthFileName, p4CatalogCurMonthFileName);
                    var fullNameLiquidation = FileName.GetFullNameLiquidation();
                    var fullNameOkved = FileName.GetFullNameOkved();
                    var fullNameOkato = FileName.GetFullNameOkato();

                    var saveResultServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurPrev), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4CurPrev));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptPrevCur), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4PrevCur));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurP4RepP1), Path.Combine(Setting.GetFolderPath(), fullNameExcRepP1));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurP4RepP4), Path.Combine(Setting.GetFolderPath(), fullNameExcRepP4));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(liquidatedOrganizations.ToList<BaseModel>()), Path.Combine(Setting.GetFolderPath(), fullNameLiquidation));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkved, 11, 23), Path.Combine(Setting.GetFolderPath(), fullNameOkved));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkato, 6, 18), Path.Combine(Setting.GetFolderPath(), fullNameOkato));

                    _message.Info("Сверка выполнена!");
                }
                else
                {
                    _message.Warn("Загружены не все данные!");
                }
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
            }
        }

        public void DockingCatalogsQuart()
        {
            try
            {
                if (p4CatalogCurQuarter.Count != 0 && p4CatalogPrevQuarter.Count != 0 && p4ReportPrevQuarter.Count != 0 && p5ReportPrevQuarter.Count != 0)
                {


                    var exceptCurPrevQuar = CatalogComparator.ExceptCatalog(p4CatalogCurQuarter.ToList<BaseModel>(), p4CatalogPrevQuarter.ToList<BaseModel>());
                    var exceptPrevCurQuar = CatalogComparator.ExceptCatalog(p4CatalogPrevQuarter.ToList<BaseModel>(), p4CatalogCurQuarter.ToList<BaseModel>());
                    var exceptP4PrevQuarP4CurQuar = CatalogComparator.ExceptCatalog(p4ReportPrevQuarter.ToList<BaseModel>(), p4CatalogCurQuarter.ToList<BaseModel>());
                    var exceptP5PrevQuarP4CurQuar = CatalogComparator.ExceptCatalog(p5ReportPrevQuarter.ToList<BaseModel>(), p4CatalogCurQuarter.ToList<BaseModel>());
                    var liquadationOrg = CatalogComparator.GetLiquidatedOrganization(p4CatalogCurQuarter);
                    var dockingOkved = CatalogComparator.GetDockingCatalog(p4CatalogCurQuarter, p4CatalogPrevQuarter, a => a.OkvedFact != a.PrevOkvedFact);
                    var dockingOkato = CatalogComparator.GetDockingCatalog(p4CatalogCurQuarter, p4CatalogPrevQuarter, a => a.OkatoFact != a.PrevOkatoFact);

                    var fullNameExceptP4CurPrev = FileName.GetFullNameExceptP4(p4CatalogCurQuarterFileName, p4CatalogPrevQuarterFileName);
                    var fullNameExceptP4PrevCur = FileName.GetFullNameExceptP4(p4CatalogPrevQuarterFileName, p4CatalogCurQuarterFileName);
                    var fullNameExcRepP5 = FileName.GetFullNameExcRep(p5ReportPrevQuarterfileName, p4CatalogCurQuarterFileName);
                    var fullNameExcRepP4 = FileName.GetFullNameExcRep(p4ReportPrevQuarterFileName, p4CatalogCurQuarterFileName);
                    var fullNameLiquidation = FileName.GetFullNameLiquidation();
                    var fullNameOkved = FileName.GetFullNameOkved();
                    var fullNameOkato = FileName.GetFullNameOkato();

                    var saveResultServices = new FileServices<ReportingModel>(new ReportingWork(_handleException));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurPrevQuar), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4CurPrev));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptPrevCurQuar), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4PrevCur));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptP5PrevQuarP4CurQuar), Path.Combine(Setting.GetFolderPath(), fullNameExcRepP5));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptP5PrevQuarP4CurQuar), Path.Combine(Setting.GetFolderPath(), fullNameExcRepP4));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(liquadationOrg.ToList<BaseModel>()), Path.Combine(Setting.GetFolderPath(), fullNameLiquidation));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkved, 11, 23), Path.Combine(Setting.GetFolderPath(), fullNameOkved));
                    saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkato, 6, 18), Path.Combine(Setting.GetFolderPath(), fullNameOkato));

                    _message.Info("Сверка выполнена!");

                }
                else
                {
                    _message.Warn("Загружены не все данные");
                }
            }
            catch (Exception ex)
            {
                _handleException.HandleExceptions(ex);
            }
        }

        public void SaveSetting(SettingModel settingModel)
        {
            var settingService = new FileServices<SettingModel>(new SettingService());
            var serializeSetting = JsonConvert.SerializeObject(settingModel);
            var bytesSetting = Encoding.UTF8.GetBytes(serializeSetting);
            settingService.Save(bytesSetting, _pathFileSettings);

            Setting.SetSetting(settingModel);

            _message.Info("Настройки сохранены!");
        }

        public void GetSetting()
        {
            var settingService = new FileServices<SettingModel>(new SettingService());
            var settings = settingService.Read(_pathFileSettings);
            Setting.SetSetting(settings[0]);
        }
    }
}
