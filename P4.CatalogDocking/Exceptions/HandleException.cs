using P4.CatalogDocking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace P4.CatalogDocking.Exceptions
{
    public class HandleException : IHandleException
    {
        private IMessage _message;

        public HandleException(IMessage message)
        {
            _message = message;
        }
        public void HandleExceptions(Exception ex)
        {
            if (ex is OkpoNullException okpoNullException)
            {
                _message.Error($"Описание ошибки: {okpoNullException.Message}\n\nТрассировка стека: {okpoNullException.StackTrace}");
                return;
            }

            if (ex is OkvedNullException okvedNullException)
            {
                _message.Error($"Описание ошибки: {okvedNullException.Message}\n\nТрассировка стека: {okvedNullException.StackTrace}");
                return;
            }

            if (ex is OkatoNullException okatoNullException)
            {
                _message.Error($"Описание ошибки: {okatoNullException.Message}\n\nТрассировка стека: {okatoNullException.StackTrace}");
                return;
            }

            if (ex is TypPredNullException typPredNullException)
            {
                _message.Error($"Описание ошибки: {typPredNullException.Message}\n\nТрассировка стека: {typPredNullException.StackTrace}");
                return;
            }

            _message.Error($"Описание ошибки: {ex.Message}\n\nТрассировка стека: {ex.StackTrace}");
        }
    }
}
