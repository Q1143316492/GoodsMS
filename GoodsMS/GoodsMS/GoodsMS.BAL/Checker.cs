using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.BAL
{
    public class Checker
    {
        public static bool Check_Number(string num)
        {
            bool ok = true;
            if (num.Length >= 10)
            {
                return false;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (!(num[i] >= '0' && num[i] <= '9'))
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        public static bool Check_Password(string pswd)
        {
            return pswd.Length >= 6;
        }

    }
}
