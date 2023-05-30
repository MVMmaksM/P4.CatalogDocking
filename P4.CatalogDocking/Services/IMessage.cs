using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public interface IMessage
    {
        void ShowMessageError(string message);
        void ShowMessageInformation(string message);
    }
}
