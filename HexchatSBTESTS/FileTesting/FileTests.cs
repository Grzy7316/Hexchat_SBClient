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
    class TestZipFileTools
    {

        public HexchatSBClient.ResultsMonitor.FileMontor FM = new HexchatSBClient.ResultsMonitor.FileMontor();
        [Test]
        public void TestZipFinder_Ex()
        {
            //FM.CheckSBresults("Z:\\IRC Downloads");
            Assert.That(() => FM.ZipFileFinder("Z:\\IRC Downloads", "zip"), Throws.Nothing);

        }
        [Test]
        public void TestZipFinder_HasRecords()
        {
            Assert.That(() => FM.ZipFileFinder("Z:\\IRC Downloads", "zip").Count > 0);
        }

        [Test]
        public void TestUnZip_ex()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "zip");

            Assert.That(() => FM.UnzipResultFiles(Files), Throws.Nothing);

        }

       

    }

    [TestFixture]
    class TestTxtFiles
    {
        public HexchatSBClient.ResultsMonitor.FileMontor FM = new HexchatSBClient.ResultsMonitor.FileMontor();
        [Test]
        public void TestFindTextFiles_ex()
        {
            Assert.That(() => FM.ZipFileFinder("Z:\\IRC Downloads", "txt"), Throws.Nothing);
        }

        [Test]
        public void TestFindTextFiles_HasRecords()
        {
            Assert.That(() => FM.ZipFileFinder("Z:\\IRC Downloads", "zip").Count > 0);
        }
        [Test]
        public void Importedtxt_ex()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            Assert.That(() => FM.Importedtxt(Files), Throws.Nothing);

        }
        [Test]
        public void Importedtxt_content()
        {
            var Files = FM.ZipFileFinder("Z:\\IRC Downloads", "txt");
            Assert.That(() => FM.Importedtxt(Files).Count > 0 );
        }

    }
}
