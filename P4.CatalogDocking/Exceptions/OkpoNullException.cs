using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Exceptions
{
    public class OkpoNullException : Exception
    {
        public OkpoNullException(int numberRowError) : base($"ошибка в строке номер: {numberRowError}\nОКПО не может быть пустым!")
        {
              
        }
    }
}
