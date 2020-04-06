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
        public List<FileInfo> ZipFileFinder(string path, string type)
        {

            DirectoryInfo SBPath = new DirectoryInfo(path);
            List<FileInfo> FileList = SBPath.GetFiles("SearchBot_results_*." + type).ToList();
            //List<String> Files = new List<String>();
            //foreach (FileInfo F in FileList)
            //{
            //    Files.Add(F.FullName);
            //}
            //return Files; 
            return FileList;

        }


        public void UnzipResultFiles(List<FileInfo> fileInfos)
        {
            foreach (FileInfo FI in fileInfos)
            {
                ZipArchive ZF = ZipFile.OpenRead(FI.FullName);
                foreach (ZipArchiveEntry E in ZF.Entries)
                {
                    try
                    {
                        E.ExtractToFile(FI.DirectoryName + "\\" + E.Name, false);
                    }
                    catch(IOException ex)
                    {
                        if (ex.Message.Contains("' already exists"))
                        {
                            
                        }
                        else
                        {
                            throw;

                        }
                    }
                }
            }
        }



        public List<string> Importedtxt(List<FileInfo> FilesList)
        {
            List<string> AllFileContents = new List<String>();
            foreach (FileInfo F in FilesList)
            {
                List<String> FileContent = new List<string>();
                var Filecontent = File.ReadAllLines(F.FullName);
                int i = 0; //Counter so we can skip first 4 lines of searchbot results 
                foreach (var s in Filecontent)
                {
                    if (i >= 4)
                    {
                        FileContent.Add(s);
                    }
                    i++;

                }
                AllFileContents.AddRange(FileContent);

            }
            return AllFileContents;

        }




    }
}
