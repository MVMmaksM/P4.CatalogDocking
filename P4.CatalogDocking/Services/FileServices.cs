using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.CatalogDocking.Services
{
    public class FileServices<T>
    {
        private IWorkFile<T> _workFile;

        public FileServices(IWorkFile<T> workFile)
        {
            _workFile = workFile;
        }

        public void Save(byte[] file, string pathFile)=> _workFile.SaveFile(bytesFile:file, pathSaveFile: pathFile);
        public List<T> Read(string pathFile) => _workFile.Read(pathFile);        
    }
}
