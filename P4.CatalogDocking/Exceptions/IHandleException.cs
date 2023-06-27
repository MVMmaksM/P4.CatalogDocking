using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Exceptions
{
    public interface IHandleException
    {
        void HandleExceptions(Exception ex);
    }
}
