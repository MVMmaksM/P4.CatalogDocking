using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models
{
    public class CatalogModel : BaseModel
    {
        public string OkvedFact { get; set; }
        public byte TypActual { get; set; }
        public CatalogModel(string okpo, string okpoUl, string name, byte okfs, short kies, long okato, int okogu, int okopf, long oktmo, byte typPred, string okvedFact, byte typActual)
            : base(okpo, okpoUl, name, okfs, kies, okato, okogu, okopf, oktmo, typPred)
        {
            OkvedFact = okvedFact;
            TypActual = typActual;
        }
    }
}
