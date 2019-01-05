using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsMS.DAL;
using GoodsMS.UI;
using GoodsMS.modle;
using GoodsMS.BAL;

namespace GoodsMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            FormRegister form = new FormRegister();
            form.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string pswd = txt_pswd.Text.Trim();
            string usid = "";
            string tp = "";
            if (name.Length == 0 || pswd.Length == 0 || cbox_type.SelectedIndex == -1)
            {
                MessageBox.Show("用户名和密码不能为空,登入模式不能为空");
                return;
            }
            DBhelper help = new DBhelper();
            string cmd = string.Format("select * from sys_user");
            DataTable dt = help.SqlSelect(cmd, "sys_user");
            bool find = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (name.Equals(dt.Rows[i][0].ToString()) && pswd.Equals(dt.Rows[i][1].ToString()))
                {
                    find = true;
                    usid = dt.Rows[i][2].ToString();
                    tp = dt.Rows[i][3].ToString();
                    break;
                }
            }
            if (find)
            {

                User us = new User(name, pswd, usid, tp);

                if (cbox_type.SelectedIndex == 0)
                {
                    MessageBox.Show("登入成功");
                    PeopleMSopt formopt = new PeopleMSopt();
                    formopt.user = us;
                    formopt.ShowDialog();
                }
                if (cbox_type.SelectedIndex == 1)
                {
                    MessageBox.Show("登入成功");
                    GoodsMSopt formopt = new GoodsMSopt();
                    formopt.user = us;
                    formopt.ShowDialog();
                }
                if (cbox_type.SelectedIndex == 2)
                {
                    if (PowerManager.get_bit(us.Type, (int)PowerManager.power.GANK_AND_GET_POWER) == 0)
                    {
                        MessageBox.Show("没有修改权限操作的权限");
                        return;
                    }
                    MessageBox.Show("登入成功");
                    FormOptPower form = new FormOptPower();
                    form.now_user = us;
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("登入失败");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
