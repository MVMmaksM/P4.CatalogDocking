using P4.CatalogDocking.Comparator;
using P4.CatalogDocking.Models.P1.Month;
using P4.CatalogDocking.Models.P4.Month;
using P4.CatalogDocking.Models.P4.Quarter;
using P4.CatalogDocking.Models.P5.Quarter;
using P4.CatalogDocking.Services;
using P4.CatalogDocking.Views;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace P4.CatalogDocking
{
    public partial class MainWindow : Window
    {
        private List<P4CatalogMonth> p4CatalogCurMonth = new List<P4CatalogMonth>();
        private List<P4CatalogMonth> p4CatalogPrevMonth = new List<P4CatalogMonth>();
        private List<P4ReportMonth> p4ReportPrevMonth = new List<P4ReportMonth>();
        private List<P4CatalogQuarter> p4CatalogCurQuarter = new List<P4CatalogQuarter>();
        private List<P4CatalogQuarter> p4CatalogPrevQuarter = new List<P4CatalogQuarter>();
        private List<P4ReportQuarter> p4ReportPrevQuarter = new List<P4ReportQuarter>();
        private List<P1ReportMonth> p1ReportPrevMonth = new List<P1ReportMonth>();
        private List<P5ReportQuarter> p5ReportPrevQuarter = new List<P5ReportQuarter>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadP4CatCurMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4CatalogMonth>(new P4CatalogMonthWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogCurMonth = loadCatalogServices.Read(pathFile);
                LblCountP4CatCurMonth.Content = StringCount.GetStringCountLoad(p4CatalogCurMonth.Count);
            }
        }

        private void LoadP4CatPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4CatalogMonth>(new P4CatalogMonthWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP4CatPrevMonth.Content = StringCount.GetStringCountLoad(p4CatalogPrevMonth.Count);
            }
        }

        private void LoadP4RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4ReportMonth>(new P4ReportMonthWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4ReportPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP4RepPrevMonth.Content = StringCount.GetStringCountLoad(p4ReportPrevMonth.Count);
            }
        }

        private void LoadP1RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P1ReportMonth>(new P1ReportMonthWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p1ReportPrevMonth = loadCatalogServices.Read(pathFile);
                LblCountP1RepPrevMonth.Content = StringCount.GetStringCountLoad(p1ReportPrevMonth.Count);
            }
        }

        private void LoadP4CatCurQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4CatalogQuarter>(new P4CatalogQuarterWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogCurQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4CatCurQuart.Content = StringCount.GetStringCountLoad(p4CatalogCurQuarter.Count);
            }
        }

        private void LoadP4CatPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4CatalogQuarter>(new P4CatalogQuarterWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4CatalogPrevQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4CatPrevQuart.Content = StringCount.GetStringCountLoad(p4CatalogPrevQuarter.Count);
            }
        }

        private void LoadP4RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P4ReportQuarter>(new P4ReportQuarterWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p4ReportPrevQuarter = loadCatalogServices.Read(pathFile);
                LblCountP4RepPrevQuart.Content = StringCount.GetStringCountLoad(p4ReportPrevQuarter.Count);
            }
        }

        private void DockingCatalogsMonth_Click(object sender, RoutedEventArgs e)
        {
            CatalogComparator.P4ExceptCatalog(p4CatalogCurMonth, p4CatalogPrevMonth);
        }

        private void DockingCatalogsQuart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadP5RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            var loadCatalogServices = new FileServices<P5ReportQuarter>(new P5ReportQuarterWork());
            var pathFile = FileDialog.ShowFileDialog();

            if (pathFile is not null)
            {
                p5ReportPrevQuarter = loadCatalogServices.Read(pathFile);
                LblCountP5RepPrevQuart.Content = StringCount.GetStringCountLoad(p5ReportPrevQuarter.Count);
            }
        }
    }
}
