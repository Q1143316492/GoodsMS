using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.modle
{
    public class GoodsMenu
    {
        private string menuId;

        public string MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private string optPeopleId;

        public string OptPeopleId
        {
            get { return optPeopleId; }
            set { optPeopleId = value; }
        }
        private string txtMsg;

        public string TxtMsg
        {
            get { return txtMsg; }
            set { txtMsg = value; }
        }
        private String number;

        public String Number
        {
            get { return number; }
            set { number = value; }
        }

        private Goods goods;

        public Goods Goods
        {
            get { return goods; }
            set { goods = value; }
        }



    }
}
