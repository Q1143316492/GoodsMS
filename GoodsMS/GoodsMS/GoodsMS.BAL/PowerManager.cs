using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using GoodsMS.modle;

namespace GoodsMS.BAL
{
    public class PowerManager
    {

        private static int POWER_SIZE = 9;

        ///1010

        public static int DEFAULT_POWER = 138;
        public static int MAX_POWER = 0x7FFFFFFF;

        public enum power {
            GANK_AND_GET_POWER,
            SELECT_PEOPLE_MSG,
            UPDATE_PEOPLE_MSG,
            SELECT_GOODS_MSG,
            UPDATE_GOODS_MSG,
            ENTRY_GOODS_MSG,
            COME_GOODS_MSG,
            BUILD_REPORT,
            DEL_USER
        };

        public static string [] powerName = {
                "给予权限",             
                "查看用户信息",
                "更新用户信息",
                "查看货物信息",
                "更新货物信息",
                "添加入库信息",
                "添加出库信息",
                "生成报表",
                "删除账户"
        };
        ///  100001010 10 + 

        public static ArrayList get_powerlist_by_power(string power)
        {
            try
            {
                ArrayList arr = new ArrayList();
                int val = Convert.ToInt32(power);
                for (int i = 0; i < POWER_SIZE; i++)
                {
                    if (get_bit(val, i) == 1)
                    {
                        arr.Add(powerName[i]);
                    }
                }
                return arr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return null;
        }

        public static ArrayList get_no_powerlist_by_power(string power)
        {
            ArrayList arr = new ArrayList();
            int val = Convert.ToInt32(power);
            for (int i = 0; i < PowerManager.POWER_SIZE; i++)
            {
                if (get_bit(val, i) == 0)
                {
                    arr.Add(powerName[i]);
                }
            }
            return arr;
        }

        public static bool update_power(ArrayList arr, User user)
        {
            if (user == null || arr == null)
            {
                return false;
            }
            int val = 0;
            for (int i = POWER_SIZE - 1; i >= 0; i--)
            {
                int is_find = 0;
                foreach (var x in arr)
                {
                    if (powerName[i].Equals(x))
                    {
                        is_find = 1;
                        break;
                    }
                }
                val <<= 1;
                val = val | is_find;
            }

            DBhelper help = new DBhelper();
            string sql = string.Format("update sys_user set usertype = {0} where username = '{1}'",
                val, user.Username);
            return help.updateDate(sql) > 0;
        }

        public static bool power_check(ArrayList arr, string name)
        {
            foreach (var x in arr)
            {
                if (x.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public static int get_bit(int p)
        {
            int v = 1;
            v <<= p;
            return v;
        }

        public static int get_bit(int val, int p)
        {
            return ((val >> p) & 1);
        }

        public static int get_bit(string val, int p)
        {
            int v = Convert.ToInt32(val);
            return ((v >> p) & 1);
        }

        public static int get_power(int type)
        {
            return get_bit(type);
        }

        public static int remove_power(int type)
        {
            return get_bit(type);
        }
    }
}
