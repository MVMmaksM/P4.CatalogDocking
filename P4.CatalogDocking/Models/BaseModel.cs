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
        public string Okfs { get; set; }
        public string TypPred { get; set; }
        public string Okopf { get; set; }
        public string Okogu { get; set; }

        protected BaseModel(string okpo, string okpoUl, string name, string okfs, string typPred, string okopf, string okogu)
        {
            Okpo = okpo;
            OkpoUl = okpoUl;
            Name = name;
            Okfs = okfs;
            TypPred = typPred;
            Okopf = okopf;
            Okogu = okogu;
        }
    }
}
