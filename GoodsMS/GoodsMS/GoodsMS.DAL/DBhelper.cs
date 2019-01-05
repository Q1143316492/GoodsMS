using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace GoodsMS
{
    public class DBhelper
    {
        public enum RESULT { SUCCESS };
        static string defaultConStr = @"server=.;database=GoodsMS;integrated security=true";

        SqlDataAdapter da;
        DataSet ds = new DataSet("tab");
        DataTable dt = new DataTable();
        
        public static string get_select_string(string tablename)
        {
            string sql = "";
            if ("sys_user".Equals(tablename))
            {
                sql = " username '用户名', userpswd '密码', userid '用户代码', usertype '权限级别'";
            }
            if ("people".Equals(tablename))
            {
                sql = " userid '人员代码', username '姓名', sex '性别', birithday '出生日期', idnumber '身份证号', "
                    + "loc_city '籍贯', home_address '家庭住址', phone '联系电话', others '其他情况' ";
            }
            if ("goods".Equals(tablename))
            {
                sql = " goods_id '物料代码', goods_name '物料名称', goods_size '规格型号', goods_unit '计量单位', "
                    + "goods_num '库存数量', note '备注' ";
            }
            return sql;
        }

        public bool MultiTrans(ArrayList arr)
        {
            SqlConnection con = new SqlConnection(defaultConStr);
            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;
            try
            { 
                foreach(var cmdTxt in arr)
                {
                    cmd.CommandText = cmdTxt.ToString();
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                return true;
            }
            catch(Exception ex)
            {
                trans.Rollback();
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }

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
            string sql = "select * from " + tablename;
            if ("sys_user".Equals(tablename))
            {
                sql = "select username '用户名', userpswd '密码', userid '用户代码', usertype '权限级别' from sys_user";
            }
            if ("people".Equals(tablename))
            {
                sql = "select userid '人员代码', username '姓名', sex '性别', birithday '出生日期', idnumber '身份证号', "
                    + "loc_city '籍贯', home_address '家庭住址', phone '联系电话', others '其他情况'  from people";
            }
            if ("goods".Equals(tablename))
            {
                sql = "select goods_id '物料代码', goods_name '物料名称', goods_size '规格型号', goods_unit '计量单位', "
                    + "goods_num '库存数量', note '备注' from goods;";
            }
            return SqlSelect(sql, tablename);
        }
    }
}
