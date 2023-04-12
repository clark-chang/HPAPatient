using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace HPA.Utility
{
    public class Oledb
    {
        private string connstring = /**/
        
        public OleDbConnection GetOleDbConnection(string ds)
        {
            /**/
            return new OleDbConnection(connstring);
        }
    }
}
