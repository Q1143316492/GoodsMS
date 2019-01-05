using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodsMS.modle;

namespace GoodsMS.BAL
{
    public class UpdateMulGoodsHelper
    {
        public static string get_menu_id(User us, DateTime dt,int count)
        {
            String key = us.Userid.ToString() + dt.ToShortDateString() + dt.ToShortTimeString() + count.ToString();
            return key;
        }

        public static string add_list_message(GoodsMenu menu, int type)
        {
            String msg = menu.Goods.Goods_id + " "+ menu.Goods.Goods_name + " ";
            msg += type == 0 ? "[入库] " : "[出库] ";
            msg += menu.Number;
            msg += " ";
            msg += menu.Goods.Goods_unit;
            return msg;
        }
    }
}
