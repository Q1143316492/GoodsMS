using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.BAL
{
    public class Checker
    {
        public static bool Check_Number(string num, bool allow_zero = true)
        {
            bool ok = true;
            if (num.Length >= 10 || num.Length <= 0)
            {
                return false;
            }
            if (num.Length == 1 && num[0] == '0')
            {
                return allow_zero;
            }
            if (num[0] == '0')
            {
                return false;   //pre_zero
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
