using P4.CatalogDocking.Comparator;
using P4.CatalogDocking.Models;
using P4.CatalogDocking.Services;
using P4.CatalogDocking.Settings;
using P4.CatalogDocking.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace P4.CatalogDocking
{
    public partial class MainWindow : Window
    {
        private List<CatalogModel> p4CatalogCurMonth = new List<CatalogModel>();
        private List<CatalogModel> p4CatalogPrevMonth = new List<CatalogModel>();
        private List<ReportingModel> p4ReportPrevMonth = new List<ReportingModel>();
        private List<CatalogModel> p4CatalogCurQuarter = new List<CatalogModel>();
        private List<CatalogModel> p4CatalogPrevQuarter = new List<CatalogModel>();
        private List<ReportingModel> p4ReportPrevQuarter = new List<ReportingModel>();
        private List<ReportingModel> p1ReportPrevMonth = new List<ReportingModel>();
        private List<ReportingModel> p5ReportPrevQuarter = new List<ReportingModel>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadP4CatCurMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogCurMonth = loadCatalogServices.Read(pathFile);
                LblCountP4CatCurMonth.Content = StringCount.GetStringCountLoad(p4CatalogCurMonth.Count);
            }
        }

        private void LoadP4CatPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP4CatPrevMonth.Content = StringCount.GetStringCountLoad(p4CatalogPrevMonth.Count);
            }
        }

        private void LoadP4RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4ReportPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP4RepPrevMonth.Content = StringCount.GetStringCountLoad(p4ReportPrevMonth.Count);
            }
        }

        private void LoadP1RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p1ReportPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP1RepPrevMonth.Content = StringCount.GetStringCountLoad(p1ReportPrevMonth.Count);
            }
        }

        private void LoadP4CatCurQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogCurQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4CatCurQuart.Content = StringCount.GetStringCountLoad(p4CatalogCurQuarter.Count);
            }
        }

        private void LoadP4CatPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<CatalogModel>(new CatalogWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogPrevQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4CatPrevQuart.Content = StringCount.GetStringCountLoad(p4CatalogPrevQuarter.Count);
            }
        }

        private void LoadP4RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<ReportingModel>(new ReportingWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4ReportPrevQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4RepPrevQuart.Content = StringCount.GetStringCountLoad(p4ReportPrevQuarter.Count);
            }
        }

        private void DockingCatalogsMonth_Click(object sender, RoutedEventArgs e)
        {
            var exceptCurPrev = CatalogComparator.ExceptCatalog(p4CatalogCurMonth.ToList<BaseModel>(), p4CatalogPrevMonth.ToList<BaseModel>());
            var exceptPrevCur = CatalogComparator.ExceptCatalog(p4CatalogPrevMonth.ToList<BaseModel>(), p4CatalogCurMonth.ToList<BaseModel>());
            var exceptCurP4RepP1 = CatalogComparator.ExceptCatalog(p1ReportPrevMonth.ToList<BaseModel>(), p4CatalogCurMonth.ToList<BaseModel>());
            var liquidatedOrganizations = CatalogComparator.GetLiquidatedOrganization(p4CatalogCurMonth);
            var dockingOkved = CatalogComparator.GetDockingCatalog(p4CatalogCurMonth, p4CatalogPrevMonth, a => a.OkvedFact != a.PrevOkvedFact);
            var dockingOkato = CatalogComparator.GetDockingCatalog(p4CatalogCurMonth, p4CatalogPrevMonth, a => a.OkatoFact != a.PrevOkatoFact);

            var fullNameExceptP4CurPrev = FileName.GetFullNameExceptP4(TxtBoxCurPeriod.Text, TxtBoxPrevPeriod.Text);
            var fullNameExceptP4PrevCur = FileName.GetFullNameExceptP4(TxtBoxPrevPeriod.Text, TxtBoxCurPeriod.Text);
            var fullNameExcRepP1 = FileName.GetFullNameExcRepP1(TxtBoxPrevPeriod.Text, TxtBoxCurPeriod.Text);
            var fullNameLiquidation = FileName.GetFullNameLiquidation();
            var fullNameOkved = FileName.GetFullNameOkved();
            var fullNameOkato = FileName.GetFullNameOkato();

            var saveResultServices = new FileServices<ReportingModel>(new ReportingWork());
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurPrev), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4CurPrev));
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptPrevCur), Path.Combine(Setting.GetFolderPath(), fullNameExceptP4PrevCur));
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(exceptCurP4RepP1), Path.Combine(Setting.GetFolderPath(), fullNameExcRepP1));
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(liquidatedOrganizations.ToList<BaseModel>()), Path.Combine(Setting.GetFolderPath(), fullNameLiquidation));
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkved, 11, 23), Path.Combine(Setting.GetFolderPath(), fullNameOkved));
            saveResultServices.Save(ExcelFileWork.GetExcelFromList(dockingOkato, 6, 18), Path.Combine(Setting.GetFolderPath(), fullNameOkato));
        }

        private void DockingCatalogsQuart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadP5RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            //var loadCatalogServices = new FileServices<P5ReportQuarter>(new P5ReportQuarterWork());
            //var pathFile = FileDialog.ShowFileDialog();

            //if (pathFile is not null)
            //{
            //    p5ReportPrevQuarter = loadCatalogServices.Read(pathFile);
            //    LblCountP5RepPrevQuart.Content = StringCount.GetStringCountLoad(p5ReportPrevQuarter.Count);
            //}
        }
    }
}
