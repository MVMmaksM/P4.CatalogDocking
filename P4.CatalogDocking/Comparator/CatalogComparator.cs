using P4.CatalogDocking.Models;
using P4.CatalogDocking.Models.P4.Month;
using P4.CatalogDocking.Models.P4.Quarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Comparator
{
    public class CatalogComparator
    {
        public static List<BaseModel> ExceptCatalog(List<BaseModel> firstCatalog, List<BaseModel> secondCatalog) => firstCatalog.Except(secondCatalog, new OkpoComparer()).ToList();
        public static List<BaseModel> GetLiquidatedOrganization(List<BaseModel> catalog) => catalog.Where(o => o.TypPred.Equals(1)).ToList();

        public List<BaseModel> GetDockingOkved() 
        {

        }
    }
}
