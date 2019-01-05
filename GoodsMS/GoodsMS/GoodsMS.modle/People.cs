using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.modle
{
    //人员代码、姓名、性别、出生日期、身份证号、籍贯、家庭住址、联系电话、其它情况
    public class People
    {
        string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        DateTime birth;
        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        string idnumber;
        public string Idnumber
        {
            get { return idnumber; }
            set { idnumber = value; }
        }
        
        string local;

        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        string home_address;

        public string Home_address
        {
            get { return home_address; }
            set { home_address = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string other;

        public string Other
        {
            get { return other; }
            set { other = value; }
        }

        public bool Check_Msg_Complete()
        {
            return userid.Length != 0 && name.Length != 0 && sex.Length != 0 && idnumber.Length != 0;
        }
    }
}
