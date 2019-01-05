using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsW
{
    //出仓的信息有出仓单号，出仓时间，操作人员代码，物料代码，进仓数量，备注
    public class come
    {
        string comeid;

        public string Comeid
        {
            get { return comeid; }
            set { comeid = value; }
        }
        string peopleid;

        public string Peopleid
        {
            get { return peopleid; }
            set { peopleid = value; }
        }
        string text2;

        public string Text2
        {
            get { return text2; }
            set { text2 = value; }
        }
        string goodsid;

        public string Goodsid
        {
            get { return goodsid; }
            set { goodsid = value; }
        }
        int comenumber;

        public int Comenumber
        {
            get { return comenumber; }
            set { comenumber = value; }
        }
        DateTime cometime;

        public DateTime Cometime
        {
            get { return cometime; }
            set { cometime = value; }
        }
    } 
}
