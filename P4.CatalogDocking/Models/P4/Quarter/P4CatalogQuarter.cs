using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models.P4.Quarter
{
    public class P4CatalogQuarter : BaseModel
    {
        public string OkatoFact { get; set; }
        public string OkvedFact { get; set; }
        public string TypActual { get; set; }

        public P4CatalogQuarter(string okpo, string okpoUl, string name, string okatoFact, string okvedFact, string typPred, string okfs, string okogu, string typActual, string okopf) :
            base(okpo: okpo, okpoUl: okpoUl, name: name, okfs: okfs, okogu: okogu, typPred: typPred, okopf: okopf)
        {
            OkatoFact = okatoFact;
            OkvedFact = okvedFact;
            TypActual = typActual;
        }
    }
}
