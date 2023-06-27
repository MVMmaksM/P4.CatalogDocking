using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Exceptions
{
    public class OkvedNullException : Exception
    {
        public OkvedNullException(int numberRowError): base($"ошибка в строке номер {numberRowError}\nОКВЭД не может быть пустым!")
        {
                
        }
    }
}
