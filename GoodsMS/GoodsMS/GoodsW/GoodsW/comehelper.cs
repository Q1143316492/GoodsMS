using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GoodsW
{
    public class comehelper
    {
        public static bool come(come coo)
        {
            DBhelper help = new DBhelper();
            string cmd = string.Format("insert into come(comeid, cometime, peopleid, text2, goodsid, comenumber)"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                coo.Comeid, coo.Cometime.ToShortDateString(), coo.Peopleid, coo.Text2,
                coo.Goodsid, coo.Comenumber);
            return help.updateDate(cmd) > 0;
        }
    }
}
