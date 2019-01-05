using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodsMS.modle;
using System.Data;
using System.Collections;

namespace GoodsMS.BAL
{
    public class GoodsMSHelper
    {
        public static bool Add_Goods_Msg(Goods goods) 
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("insert into goods(goods_id, goods_name, goods_size, goods_unit, goods_num, note)"
                + "values('{0}', '{1}', '{2}', '{3}', {4}, '{5}')",
                goods.Goods_id, goods.Goods_name, goods.Goods_size, goods.Goods_unit, goods.Goods_num, goods.Others);
            return help.updateDate(cmd) > 0;
        }

        public static bool Del_goods_by_goodsId(string goods_id)
        {
            //DBhelper help = new DBhelper();
            //string cmd = string.Format("delete from goods where goods_id = '{0}'", goods_id);
            //return help.updateDate(cmd) > 0;
            ArrayList arr = new ArrayList();
            string cmd1 = string.Format("delete from goods where goods_id = '{0}'", goods_id);
            string cmd2 = string.Format("delete from entry where goodsid = '{0}'", goods_id);
            string cmd3 = string.Format("delete from come where goodsid = '{0}'", goods_id);
            arr.Add(cmd1);
            arr.Add(cmd2);
            arr.Add(cmd3);
            DBhelper help = new DBhelper();
            return help.MultiTrans(arr);
        }

        public static Goods Select_goods_by_goodsId(string goods_id)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("select goods_id, goods_name, goods_size, goods_unit, goods_num, note from goods "
                + "where goods_id = '{0}' ", goods_id);
            DataTable dt = help.SqlSelect(cmd, "goods");
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            Goods goods = new Goods();
            goods.Goods_id = dt.Rows[0]["goods_id"].ToString();
            goods.Goods_name = dt.Rows[0]["goods_name"].ToString();
            goods.Goods_size = dt.Rows[0]["goods_size"].ToString();
            goods.Goods_unit = dt.Rows[0]["goods_unit"].ToString();
            goods.Goods_num = dt.Rows[0]["goods_num"].ToString();
            goods.Others = dt.Rows[0]["note"].ToString();
            return goods;
        }

        public static bool Update_goods_msg(Goods goods)
        {
            DBhelper help = new DBhelper();
            //goods_id, goods_name, goods_size, goods_unit, goods_num, note
            string cmd = string.Format("update goods "
                + "set goods_name = '{0}', "
                + "goods_size = '{1}', "
                + "goods_unit = '{2}', "
                + "goods_num = {3} , "
                + "note = '{4}' "
                + "where goods_id = '{5}'",
                goods.Goods_name,
                goods.Goods_size,
                goods.Goods_unit,
                goods.Goods_num,
                goods.Others,
                goods.Goods_id
                );
            return help.updateDate(cmd) > 0;
        }

        //入库
        public static string entry_goods(GoodsMenu menu)
        {
            string sql = String.Format("insert into entry (entryid, entrytime, peopleid, text1, goodsid, entrynumber) "
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                menu.MenuId, menu.Date ,menu.OptPeopleId, menu.TxtMsg, menu.Goods.Goods_id, menu.Number);
            return sql;
        }

        //出库
        public static string come_goods(GoodsMenu menu)
        {
            string sql = String.Format("insert into come (comeid, cometime, peopleid, text2, goodsid, comenumber) "
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                menu.MenuId, menu.Date, menu.OptPeopleId, menu.TxtMsg, menu.Goods.Goods_id, menu.Number);
            return sql;
        }

        public static string report_goods(GoodsMenu menu)
        {
            string sql = String.Format("insert into report (comeid, cometime, peopleid, text2, goodsid, comenumber) "
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                menu.MenuId, menu.Date, menu.OptPeopleId, menu.TxtMsg, menu.Goods.Goods_id, menu.Number);
            return sql;
        }

        public static string Update_goods_number(Goods goods, string number, int type)
        {
            if (type == 0)
            {
                return String.Format("update goods set goods_num = goods_num + {0} where goods_id = '{1}' "
                        , number, goods.Goods_id);
            }
            else
            {
                return String.Format("update goods set goods_num = goods_num - {0} where goods_id = '{1}' "
                        , number, goods.Goods_id);
            }
        }

        public static bool multy_post_menu(ArrayList arr)
        {
            DBhelper help = new DBhelper();
            return help.MultiTrans(arr);
        }
    }

}
