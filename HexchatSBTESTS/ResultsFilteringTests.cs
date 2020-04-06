using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using HexchatSBClient.ResultsManager;

namespace HexchatSBTESTS
{
    [TestFixture]
    class ResultsTesting
    {

        public FileMonitor FM = new FileMonitor();
        public ResultFiltering RF = new ResultFiltering();
        [Test]
        public void UnfilteredResultsTable_Ex()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.ResultsTable(ResultsFiles), Throws.Nothing); 
        }
        [Test]
        public void UnfilteredResultsTable_Contents()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.ResultsTable(ResultsFiles).Rows.Count > 0  );
        }
       
       
       
        [Test]
        public void FilterResults_ex_nofilter()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.FilteredResults(ResultsFiles), Throws.Nothing); 


        }
        [Test]
        public void FilterResults_ex_filter()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.FilteredResults(ResultsFiles, "Warden"), Throws.Nothing);


        }
        [Test]
        public void FilterResults_content_filter()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.FilteredResults(ResultsFiles, "Warden").Count > 3);


        }
        [Test]
        public void FilterResults_content_nofilter()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            var ResultsFiles = FM.Importedtxt(Files);
            Assert.That(() => RF.FilteredResults(ResultsFiles).Count > 3);


        }


    }
}
