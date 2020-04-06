using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Compatibility;
using HexchatSBClient;



namespace HexchatSBTESTS.FileTesting
{
    [TestFixture]
    class TestFileFinder    
    {
        public HexchatSBClient.ResultsMonitor.FileMontor FM = new HexchatSBClient.ResultsMonitor.FileMontor();

       [Test]
        public void TestFileGetter()
        {
            FM.CheckSBresults("Z:\\IRC Downloads");
            Assert.That(() => FM.CheckSBresults("Z:\\IRC Downloads"), Throws.Nothing);

        } 

    }
}
