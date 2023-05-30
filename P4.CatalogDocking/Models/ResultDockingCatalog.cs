using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models
{
    public class ResultDockingCatalog : BaseModel
    {       
        public string OkvedFact { get; set; }
        public byte TypActual { get; set; }
        public string PrevOkpo { get; set; }
        public string PrevOkpoUl { get; set; }
        public string PrevName { get; set; }
        public byte PrevOkfs { get; set; }
        public byte PrevTypPred { get; set; }
        public int PrevOkopf { get; set; }
        public int PrevOkogu { get; set; }
        public long PrevOkatoFact { get; set; }
        public long PrevOktmo { get; set; }
        public string PrevOkvedFact { get; set; }
        public byte PrevTypActual { get; set; }
        public short PrevKies { get; set; }

        public ResultDockingCatalog
            (string okpo, 
            string okpoUl, 
            string name,             
            byte okfs,
            short kies,
            long okatoFact,
            int okogu, 
            int okopf,
            long oktmo,            
            byte typPred,
            string okvedFact,
            byte typActual,
            string prevOkpo,
            string prevOkpoUl,
            string prevName,
            byte prevOkfs,
            short prevKies,
            long prevOkato,
            int prevOkogu,
            int prevOkopf,
            long prevoktmo,
            byte prevTypPred,
            string prevOkvedFact,
            byte prevTypActual)
            : base(okpo: okpo, okpoUl: okpoUl, name: name, okfs: okfs, kies: kies, okatoFact: okatoFact, okogu: okogu, okopf: okopf, oktmo: oktmo, typPred: typPred)
        {           
            OkvedFact = okvedFact;
            TypActual = typActual;
            PrevOkpo = prevOkpo;
            PrevOkpoUl = prevOkpoUl;
            PrevName = prevName;
            PrevOkfs = prevOkfs;
            PrevKies = prevKies;
            PrevOkatoFact = prevOkato;
            PrevOkogu = prevOkogu;
            PrevOkopf = prevOkopf;
            PrevOktmo = prevoktmo;
            PrevTypPred = prevTypPred;          
            PrevOkvedFact = prevOkvedFact;
            PrevTypActual = prevTypActual;
        }
    }
}
