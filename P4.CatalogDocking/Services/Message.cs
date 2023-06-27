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
        public void Error(string messageError)
        {
            MessageBox.Show(messageError, "Ошибка", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }
        public void Info(string messageInfo)
        {
            MessageBox.Show(messageInfo, "Информация", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        public void Warn(string messageWarn)
        {
            MessageBox.Show(messageWarn, "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }
    }
}
