using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P4.CatalogDocking.Services
{
    public class Message : IMessage
    {
        public void ShowMessageError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ShowMessageInformation(string message)
        {
            MessageBox.Show(message, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
