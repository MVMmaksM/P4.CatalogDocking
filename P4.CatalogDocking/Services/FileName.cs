using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public static class FileName
    {
        public static string GetFullNameExceptP4(string currentPeriod, string previousPeriod) => $"Есть в каталоге П-4 за {currentPeriod}, нет в каталоге П-4 за {previousPeriod}.xlsx";    
        public static string GetFullNameExcRepP1(string currentPeriod, string previousPeriod) => $"Отчитались по П-1 за {currentPeriod}, нет в каталоге П-4 за {previousPeriod}.xlsx"; 
        public static string GetFullNameExcRepP5(string currentPeriod, string previousPeriod) => $"Отчитались по П-5 за {currentPeriod}, нет в каталоге П-4 за {previousPeriod}.xlsx"; 
        public static string GetFullNameOkved() => $"Расхождение по ОКВЭД.xlsx"; 
        public static string GetFullNameOkato() => $"Расхождение по ОКАТО.xlsx"; 
        public static string GetFullNameLiquidation() => $"Исключенные.xlsx"; 

    }
}
