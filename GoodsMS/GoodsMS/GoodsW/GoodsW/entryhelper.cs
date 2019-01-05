using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GoodsW
{
    public class entryhelper
    {
        public static bool goods(entry enn)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("insert into entry(entryid, entrytime, peopleid, text1, goodsid, entrynumber)"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                enn.Entryid, enn.Entrytime.ToShortDateString(), enn.Peopleid, enn.Text1,
                enn.Goodsid, enn.Entrynumber);
            return help.updateDate(cmd) > 0;
        }
    }

    public class SystemDBhelper
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
