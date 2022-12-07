using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_MS.helpers
{
     public class SqlData
    {
        
        public static string Constring = ConfigurationManager.ConnectionStrings["constring"].ToString();
        SqlConnection con = new SqlConnection(Constring);
        public void Opencon()
        {
           // con = new SqlConnection(Constring);
            con.Open();
        }
        public void Closecon()
        {
            con.Close();
        }
        public void NonQuerryExecuter(string Querry)
        {

           SqlCommand cm = new SqlCommand(Querry, con);
            cm.ExecuteNonQuery();   
          
        }
    }
}
