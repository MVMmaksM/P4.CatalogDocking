using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public static class FileName
    {
        public static string GetFullNameExceptP4(string currentPeriod, string previousPeriod) => $"Есть в каталоге {currentPeriod}, нет в каталоге {previousPeriod}.xlsx";    
        public static string GetFullNameExcRep(string currentPeriod, string previousPeriod) => $"Отчитались {currentPeriod}, нет в каталоге {previousPeriod}.xlsx";      
        public static string GetFullNameOkved() => $"Расхождение по ОКВЭД.xlsx"; 
        public static string GetFullNameOkato() => $"Расхождение по ОКАТО.xlsx"; 
        public static string GetFullNameLiquidation() => $"Исключенные.xlsx"; 

    }
}
