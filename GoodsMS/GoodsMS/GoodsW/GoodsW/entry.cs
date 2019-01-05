using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsW
{

    //进仓的信息有进仓单号，进仓时间，操作人员代码，物料代码，进仓数量，备注
    public class entry
    {
        string entryid;

        public string Entryid
        {
            get { return entryid; }
            set { entryid = value; }
        }
        string peopleid;

        public string Peopleid
        {
            get { return peopleid; }
            set { peopleid = value; }
        }
        string text1;

        public string Text1
        {
            get { return text1; }
            set { text1 = value; }
        }
        string goodsid;

        public string Goodsid
        {
            get { return goodsid; }
            set { goodsid = value; }
        }



        int entrynumber;

        public int Entrynumber
        {
            get { return entrynumber; }
            set { entrynumber = value; }
        }

        DateTime entrytime;

        public DateTime Entrytime
        {
            get { return entrytime; }
            set { entrytime = value; }
        }
    }
}
