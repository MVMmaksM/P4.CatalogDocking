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
        private Facade _facadeWork;

        public MainWindow()
        {
            InitializeComponent();
            _facadeWork = new Facade(new Message());
        }

        private void LoadP4CatCurMonth_Click(object sender, RoutedEventArgs e)
        {
            LblCountP4CatCurMonth.Content = _facadeWork.LoadP4CatCurMonth();
        }

        private void LoadP4CatPrevMonth_Click(object sender, RoutedEventArgs e)
        {            
            LblCountP4CatPrevMonth.Content = _facadeWork.LoadP4CatPrevMonth();
        }

        private void LoadP4RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            LblCountP4RepPrevMonth.Content = _facadeWork.LoadP4RepPrevMonth();
        }

        private void LoadP1RepPrevMonth_Click(object sender, RoutedEventArgs e)
        {
            LblCountP1RepPrevMonth.Content = _facadeWork.LoadP1RepPrevMonth();
        }

        private void LoadP4CatCurQuart_Click(object sender, RoutedEventArgs e)
        {
            LblCountP4CatCurQuart.Content = _facadeWork.LoadP4CatCurQuart();
        }

        private void LoadP4CatPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            LblCountP4CatPrevQuart.Content = _facadeWork.LoadP4CatPrevQuart(); 
        }

        private void LoadP4RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            LblCountP4RepPrevQuart.Content = _facadeWork.LoadP4RepPrevQuart();
        }

        private void DockingCatalogsMonth_Click(object sender, RoutedEventArgs e)
        {
            _facadeWork.DockingCatalogsMonth();
        }

        private void DockingCatalogsQuart_Click(object sender, RoutedEventArgs e)
        {
            _facadeWork.DockingCatalogsQuart();
        }

        private void LoadP5RepPrevQuart_Click(object sender, RoutedEventArgs e)
        {
            LblCountP5RepPrevQuart.Content = _facadeWork.LoadP5RepPrevQuart();
        }
    }
}
