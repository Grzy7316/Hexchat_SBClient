using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using HexchatSBClient.ResultsManager;

namespace HexchatSBClient
{
    public partial class Form1 : Form
    {
        public ResultsManager.FileMonitor FM = new FileMonitor();
        public ResultsManager.ResultFiltering RF = new ResultFiltering();
        public List<String> UnfilteredResults = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
            var myTimer = new System.Timers.Timer();
            myTimer.Interval = 30000;
            myTimer.Enabled = true;
            myTimer.Elapsed += new ElapsedEventHandler(myEvent);

        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            var FilteredResults = RF.FilteredResults(UnfilteredResults, FilterBox.Text);
            var FilteredTable = RF.ResultsTable(FilteredResults);
            ResultsGrid.DataSource = FilteredTable;
        }

        public bool UpdateDataGrid()
        {
            var Zipfiles = FM.ZipFileFinder(FolderPathBox.Text, "zip");
            FM.UnzipResultFiles(Zipfiles);
            var textfiles = FM.ZipFileFinder(FolderPathBox.Text, "txt");
            UnfilteredResults = FM.Importedtxt(textfiles);
            var Results = RF.FilteredResults(UnfilteredResults, FilterBox.Text);
            var InitialResults = RF.ResultsTable(Results);
            ResultsGrid.DataSource = InitialResults;
            return true;
        }

        private void myEvent(object source, ElapsedEventArgs e)
        {
            var Zipfiles = FM.ZipFileFinder(FolderPathBox.Text, "zip");
            FM.UnzipResultFiles(Zipfiles);
            var textfiles = FM.ZipFileFinder(FolderPathBox.Text, "txt");
            UnfilteredResults = FM.Importedtxt(textfiles);
            var Results = RF.FilteredResults(UnfilteredResults, FilterBox.Text);
            var InitialResults = RF.ResultsTable(Results);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderPathBox.Text = KnownFolders.GetPath(KnownFolder.Downloads);
        }


    }
}