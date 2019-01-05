using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.modle
{
    public class Goods
    {
        string goods_id;

        public string Goods_id
        {
            get { return goods_id; }
            set { goods_id = value; }
        }
        string goods_name;

        public string Goods_name
        {
            get { return goods_name; }
            set { goods_name = value; }
        }
        string goods_size;

        public string Goods_size
        {
            get { return goods_size; }
            set { goods_size = value; }
        }
        string goods_unit;

        public string Goods_unit
        {
            get { return goods_unit; }
            set { goods_unit = value; }
        }
        string goods_num;

        public string Goods_num
        {
            get { return goods_num; }
            set { goods_num = value; }
        }
        string others;

        public string Others
        {
            get { return others; }
            set { others = value; }
        }

        public bool Check_Msg_Complete()
        {
            return goods_id.Length != 0 && goods_name.Length != 0 && goods_size.Length != 0
                && goods_unit.Length != 0 && goods_num.Length != 0 && others.Length != 0;
        }

    }
}
