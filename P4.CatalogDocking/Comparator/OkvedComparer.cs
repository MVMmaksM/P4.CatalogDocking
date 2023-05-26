using P4.CatalogDocking.Models;
using P4.CatalogDocking.Models.P4.Month;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Comparator
{
    internal class OkvedComparer : IEqualityComparer<P4CatalogMonth>
    {
        public bool Equals(P4CatalogMonth? firstValue, P4CatalogMonth? secondValue) => (firstValue?.Okpo == secondValue?.Okpo && firstValue?.OkvedFact == secondValue?.OkvedFact);
        public int GetHashCode([DisallowNull] P4CatalogMonth obj) => (obj.Okpo + obj.OkvedFact).GetHashCode();       
    }
}
