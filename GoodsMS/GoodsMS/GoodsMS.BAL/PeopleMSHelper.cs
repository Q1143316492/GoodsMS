using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GoodsMS.modle;
using GoodsMS.DAL;
using System.Collections;

namespace GoodsMS.BAL
{
    public class PeopleMSHelper
    {
        public static bool Add_people_msg(People peo) 
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("insert into people(userid, username, sex, birithday, idnumber, loc_city, home_address, phone, others)"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                peo.Userid, peo.Name, peo.Sex, peo.Birth.ToShortDateString(),
                peo.Idnumber, peo.Local, peo.Home_address, peo.Phone, peo.Other);
            return help.updateDate(cmd) > 0;
        }

        public static bool Add_people_msg(ArrayList arr)
        {
            DBhelper help = new DBhelper();
            return help.MultiTrans(arr);
        }

        public static string Add_people_msgstr(People peo)
        {
            string cmd = string.Format("insert into people(userid, username, sex, birithday, idnumber, loc_city, home_address, phone, others)"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                peo.Userid, peo.Name, peo.Sex, peo.Birth.ToShortDateString(),
                peo.Idnumber, peo.Local, peo.Home_address, peo.Phone, peo.Other);
            return cmd;
        }

        public static bool Add_user_by_UserMsg(User user)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("insert into sys_user(username, userpswd, userid, usertype)"
                + "values('{0}', '{1}', '{2}', {3})", user.Username, user.Password, user.Userid, user.Type);
            return help.updateDate(cmd) > 0;
        }

        public static string Add_user_by_UserMsgstr(User user)
        {
            string cmd = string.Format("insert into sys_user(username, userpswd, userid, usertype)"
                + "values('{0}', '{1}', '{2}', {3})", user.Username, user.Password, user.Userid, user.Type);
            return cmd;
        }

        public static bool Del_people_by_userid(string userid)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("delete from people where userid = '{0}'", userid);
            return help.updateDate(cmd) > 0;
        }

        public static People Select_people_by_usid(string userid)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("select userid, username, sex, birithday, idnumber, loc_city, home_address, phone, others from people " 
                + "where userid = '{0}' ", userid);
            DataTable dt = help.SqlSelect(cmd, "people");
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            People people = new People();
            people.Userid = dt.Rows[0]["userid"].ToString();
            people.Name = dt.Rows[0]["username"].ToString();
            people.Sex = dt.Rows[0]["sex"].ToString();
            people.Birth = (DateTime)dt.Rows[0]["birithday"];
            people.Idnumber = dt.Rows[0]["idnumber"].ToString();
            people.Local = dt.Rows[0]["loc_city"].ToString();
            people.Home_address = dt.Rows[0]["home_address"].ToString();
            people.Phone = dt.Rows[0]["phone"].ToString();
            people.Other = dt.Rows[0]["others"].ToString();
            return people;
        }

        public static bool Delete_user_and_userMsg(User user)
        {
            ArrayList arr = new ArrayList();
            string sql1 = string.Format("delete from sys_user where username = '{0}'", user.Username);
            string sql2 = string.Format("delete from people where userid = '{0}'", user.Userid);
            arr.Add(sql1);
            arr.Add(sql2);
            DBhelper help = new DBhelper();
            return help.MultiTrans(arr);
        }

        public static User get_user_by_username(string username)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("select username, userpswd, userid, usertype from sys_user "
                + "where username = '{0}' ", username);
            DataTable dt = help.SqlSelect(cmd, "sys_user");
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            User user = new User();
            user.Username = dt.Rows[0]["username"].ToString();
            user.Password = dt.Rows[0]["userpswd"].ToString();
            user.Userid = dt.Rows[0]["userid"].ToString();
            user.Type = dt.Rows[0]["usertype"].ToString();
            return user;
            
        }

        public static bool Update_User_msg(User user)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("update sys_user "
                + "set username = '{0}', "
                + "userpswd = '{1}', "
                + "userid  = '{2}', "
                + "usertype  = {3} "
                + "where username = '{4}'",
                user.Username,
                user.Password,
                user.Userid,
                user.Type,
                user.Username
                );
            return help.updateDate(cmd) > 0;
        }

        public static bool Update_people_msg(People people)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("update people "
                + "set username = '{0}', "
                + "sex = '{1}', "
                + "birithday = '{2}', "
                + "idnumber = '{3}', "
                + "loc_city = '{4}', "
                + "home_address = '{5}', "
                + "phone = '{6}', "
                + "others = '{7}' "
                + "where userid = '{8}' ", 
                people.Name, 
                people.Sex,
                people.Birth,
                people.Idnumber,
                people.Local,
                people.Home_address,
                people.Phone,
                people.Other,
                people.Userid);
            return help.updateDate(cmd) > 0;
        }

    }

    public class SystemHelper 
    {
        public static DataTable getTable(string tableName)
        {
            DBhelper help = new DBhelper();
            return help.getTableByName(tableName);
        }

        public static DataTable getTableBySql(string cmd, string tableName)
        {
            DBhelper help = new DBhelper();
            return help.SqlSelect(cmd, tableName);
        }
    }
}
