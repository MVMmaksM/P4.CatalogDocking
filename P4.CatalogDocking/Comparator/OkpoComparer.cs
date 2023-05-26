using P4.CatalogDocking.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Comparator
{
    internal class OkpoComparer : IEqualityComparer<BaseModel>
    {
        public bool Equals(BaseModel? firstValue, BaseModel? seconddValue) => firstValue?.Okpo == seconddValue?.Okpo;
        public int GetHashCode([DisallowNull] BaseModel obj) => (obj.Okpo + obj.OkpoUl).GetHashCode(); 
    }
}
