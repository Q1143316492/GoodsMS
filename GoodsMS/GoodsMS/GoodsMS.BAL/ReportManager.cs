using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodsMS.DAL;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using GoodsMS.modle;

namespace GoodsMS.BAL
{
    public class ReportManager
    {
        public static bool init_come_report(DateTime begin, DateTime end)
        {
            DBhelper help = new DBhelper();
            help.updateDate("delete from report");
            string sql1 = string.Format("select * from come where cometime between '{0}' and '{1}'",
                begin.ToShortDateString(), end.AddDays(1).ToShortDateString());
            DataTable dt = help.SqlSelect(sql1, "come");
            if (dt == null)
            {
                return false;
            }
            ArrayList arr = new ArrayList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GoodsMenu menu = new GoodsMenu();
                menu.MenuId = dt.Rows[i]["comeid"].ToString();
                menu.Date = (DateTime)dt.Rows[i]["cometime"];
                menu.OptPeopleId = dt.Rows[i]["peopleid"].ToString();
                menu.TxtMsg = dt.Rows[i]["text2"].ToString();
                menu.Goods = GoodsMSHelper.Select_goods_by_goodsId(dt.Rows[i]["goodsid"].ToString());
                menu.Number = dt.Rows[i]["comenumber"].ToString();
                string sql = GoodsMSHelper.report_goods(menu);
                arr.Add(sql);
            }
            return help.MultiTrans(arr);
        }

        public static bool init_entry_report(DateTime begin, DateTime end)
        {
            DBhelper help = new DBhelper();
            help.updateDate("delete from report");
            string sql1 = string.Format("select * from entry where entrytime between '{0}' and '{1}'",
                begin.ToShortDateString(), end.AddDays(1).ToShortDateString());
            DataTable dt = help.SqlSelect(sql1, "entry");
            if (dt == null)
            {
                return false;
            }
            ArrayList arr = new ArrayList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GoodsMenu menu = new GoodsMenu();
                menu.MenuId = dt.Rows[i]["entryid"].ToString();
                menu.Date = (DateTime)dt.Rows[i]["entrytime"];
                menu.OptPeopleId = dt.Rows[i]["peopleid"].ToString();
                menu.TxtMsg = dt.Rows[i]["text1"].ToString();
                menu.Goods = GoodsMSHelper.Select_goods_by_goodsId(dt.Rows[i]["goodsid"].ToString());
                menu.Number = dt.Rows[i]["entrynumber"].ToString();
                string sql = GoodsMSHelper.report_goods(menu);
                arr.Add(sql);
            }
            return help.MultiTrans(arr);
        }
    }
}
