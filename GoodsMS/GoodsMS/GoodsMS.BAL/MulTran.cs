using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodsMS.DAL;
using System.Collections;

namespace GoodsMS.BAL
{
    public class MulTran
    {
        public static bool multiple_trans_test()
        {
            ArrayList arr = new ArrayList();
            arr.Add("insert into sys_user(username, userpswd) values ('test1', '123456')");
            arr.Add("insert into sys_user(username, userpswd) values ('test2', '123456')");
            DBhelper help = new DBhelper();
            return help.MultiTrans(arr);
        }
    }
}
