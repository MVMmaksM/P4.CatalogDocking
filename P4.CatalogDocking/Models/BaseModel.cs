using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models
{
    public abstract class BaseModel
    {
        public string Okpo { get; set; }
        public string OkpoUl { get; set; }
        public string Name { get; set; }
        public byte Okfs { get; set; }
        public short Kies { get; set; }
        public long OkatoFact { get; set; }
        public int Okogu { get; set; }
        public int Okopf { get; set; }
        public long Oktmo { get; set; }
        public byte TypPred { get; set; }

        protected BaseModel(string okpo, string okpoUl, string name, byte okfs, short kies, long okatoFact, int okogu, int okopf, long oktmo, byte typPred)
        {
            Okpo = okpo;
            OkpoUl = okpoUl;
            Name = name;
            Okfs = okfs;
            Kies = kies;
            OkatoFact = okatoFact;
            Okogu = okogu;
            Okopf = okopf;
            Oktmo = oktmo;
            TypPred = typPred;            
        }
    }
}
