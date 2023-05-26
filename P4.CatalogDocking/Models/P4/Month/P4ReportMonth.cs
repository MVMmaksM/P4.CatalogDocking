using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models.P4.Month
{
    public class P4ReportMonth:BaseModel
    {
        public string Okato { get; set; }
        public string OkvedHoz { get; set; }
        public string Kies { get; set; }
        public string Oktmo { get; set; }

        public P4ReportMonth(string okpo, string okpoUl, string name, string okato, string okvedHoz, string typPred, string okfs, string okogu, string okopf, string kies, string oktmo) :
            base(okpo: okpo, okpoUl: okpoUl, name: name, okfs: okfs, okogu: okogu, typPred: typPred, okopf: okopf)
        {
            Okato = okato;
            OkvedHoz = okvedHoz;
            Kies = kies;
            Oktmo = oktmo;
        }
    }
}
