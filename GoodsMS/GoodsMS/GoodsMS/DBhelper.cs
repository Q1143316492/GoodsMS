using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GoodsMS
{
    class TmpDBhelper
    {
        public enum RESULT { SUCCESS };
        static string defaultConStr = @"server=.;database=GoodsMS;integrated security=true";

        SqlDataAdapter da;
        DataSet ds = new DataSet("tab");
        DataTable dt = new DataTable();
        
        public DataTable SqlSelect(string sqlcmd, string tableName)
        {
            SqlConnection con = new SqlConnection(defaultConStr);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            ds = new DataSet(tableName);
            dt = new DataTable();
            
            da.Fill(ds, tableName);
            dt = ds.Tables[tableName];
            con.Close();
            
            return dt;
        }
    }
}
