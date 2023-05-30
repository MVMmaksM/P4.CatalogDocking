using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Models
{
    public class ReportingModel: BaseModel
    {    
        public string OkvedHoz { get; set; }
        public ReportingModel(string okpo, string okpoUl, string name, byte okfs, short kies, long okato, int okogu, int okopf, long oktmo, byte typPred, string okvedHoz)
            : base(okpo, okpoUl, name, okfs, kies, okato, okogu, okopf, oktmo, typPred)
        {
            OkvedHoz = okvedHoz;            
        }
    }
}
