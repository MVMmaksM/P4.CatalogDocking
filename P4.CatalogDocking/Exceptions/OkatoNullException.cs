using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Exceptions
{
    public class OkatoNullException : Exception
    {
        public OkatoNullException(int numberRowError): base($"ошибка в строке номер {numberRowError}\nОКАТО не может быть пустым!")
        {
                
        }
    }
}
