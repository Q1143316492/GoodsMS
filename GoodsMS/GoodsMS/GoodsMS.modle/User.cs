using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodsMS.modle
{
    public class User
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string userid;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public User() { }

        public User(string name, string pswd, string id, string tp)
        {
            username = name;
            password = pswd;
            userid = id;
            type = tp;
        }


    }
}
