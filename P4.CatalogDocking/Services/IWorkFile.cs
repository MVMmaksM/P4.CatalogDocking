using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public interface IWorkFile<T>
    {
        List<T> Read(string pathFile);
        void SaveFile(byte[] bytesFile, string pathSaveFile);
    }
}
