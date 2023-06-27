using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Exceptions
{
    public class TypPredNullException : Exception
    {
        public TypPredNullException(int numberRowError): base($"ошибка в строке нмоер: {numberRowError}\nТип предприятия не может быть пустым!")
        {
                
        }
    }
}
