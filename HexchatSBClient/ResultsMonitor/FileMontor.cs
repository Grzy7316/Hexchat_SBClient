using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace HexchatSBClient.ResultsMonitor
{
    public class FileMontor
    {
        public List<FileInfo>  CheckSBresults(string path )
        {
           
            DirectoryInfo SBPath = new DirectoryInfo(path);
            List<FileInfo> FileList = SBPath.GetFiles("SearchBot_results_*.zip").ToList();
            //var Files = .ToList();
            
            return FileList; 
            
        }


        //public void UnzipFile(FileInfo File )
        //{
        //    var Entries = ZipArchive.Entries
        //}

    }
}
