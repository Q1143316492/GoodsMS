using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GoodsW    
{
    public class DBhelper
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

        public int updateDate(string sqlStr)
        {
            string connString = defaultConStr;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            conn.Open();
            int cnt = 0;
            try
            {
                cnt = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("EX:" + ex);
            }
            finally
            {
                conn.Close();
            }
            return cnt;
        }

        public DataTable getTableByName(string tablename)
        {
            return SqlSelect("select * from " + tablename, tablename);
        }
    }
}
