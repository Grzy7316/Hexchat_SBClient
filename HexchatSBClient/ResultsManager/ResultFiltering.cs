using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO; 

namespace HexchatSBClient.ResultsManager
{
    public class ResultFiltering
    {

        public DataTable ResultsTable(List<String> FileContents, string filter = "" )
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("SearchResult");
         
              
                foreach (string s in FileContents)
                {


                    DataRow R = DT.NewRow();
                    R["SearchResult"] = s;
                    DT.Rows.Add(R);

                }
            return DT;
        }
        public List<String> FilteredResults(List<string> unfilteredResults, string filter = "")
        {
            List<string> FR = new List<string>();
            if (filter == "")
            {
                FR = unfilteredResults;
            }
            else 
            {
                FR = unfilteredResults.FindAll(r => r.Contains(filter));
            }
            return FR; 
        }
            
        


   
      
    }
    
}
