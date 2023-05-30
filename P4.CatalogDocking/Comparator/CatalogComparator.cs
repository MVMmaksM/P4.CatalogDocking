using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Comparator
{
    public class CatalogComparator
    {
        public static List<BaseModel> ExceptCatalog(List<BaseModel> firstCatalog, List<BaseModel> secondCatalog) => firstCatalog.Except(secondCatalog, new OkpoComparer()).ToList();
        public static List<CatalogModel> GetLiquidatedOrganization(List<CatalogModel> catalog) => catalog.Where(o => o.TypActual.Equals(1)).ToList();
        public static List<ResultDockingCatalog> GetDockingCatalog(List<CatalogModel> firstCatalog, List<CatalogModel> secondCatalog, Func<ResultDockingCatalog, bool> predicateOkved) =>
                firstCatalog.Join(secondCatalog,
                f => f.Okpo,
                s => s.Okpo,
                (f, s) => new ResultDockingCatalog
                (okpo: f.Okpo,
                okpoUl: f.OkpoUl,
                name: f.Name,
                okfs: f.Okfs,
                kies: f.Kies,
                okatoFact: f.OkatoFact,
                okogu: f.Okogu,
                okopf: f.Okopf,
                oktmo: f.Oktmo,
                typPred: f.TypPred,
                okvedFact: f.OkvedFact,
                typActual: f.TypActual,
                prevOkpo: s.Okpo,
                prevOkpoUl: s.OkpoUl,
                prevName: s.Name,
                prevOkfs: s.Okfs,
                prevKies: s.Kies,
                prevOkato: s.OkatoFact,
                prevOkogu: s.Okogu,
                prevOkopf: s.Okopf,
                prevoktmo: s.Oktmo,
                prevTypPred: s.TypPred,
                prevOkvedFact: s.OkvedFact,
                prevTypActual: s.TypActual
                ))
                .Where(predicateOkved).ToList();



    }
}
