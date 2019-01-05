using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsMS.modle;
using GoodsMS.BAL;

namespace GoodsMS.UI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认注册", "确认注册?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (txt_name.Text.Trim() == null || txt_name.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            if (txt_pswd1.Text.Trim() == null || txt_pswd1.Text.Trim().Equals("")
                || txt_pswd2.Text.Trim() == null || txt_pswd2.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (txt_pswd1.Text.Trim().Equals(txt_pswd2.Text.Trim()) == false)
            {
                MessageBox.Show("两次输入密码不一致");
                return;
            }
            User user = new User();
            user.Username = txt_name.Text.Trim();
            user.Password = txt_pswd1.Text.Trim();
            user.Userid = user.Username;
            user.Type = Convert.ToString((int)PowerManager.DEFAULT_POWER);
            if (PeopleMSHelper.Add_user_by_UserMsg(user))
            {
                MessageBox.Show("注册成功");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("已存在用户名");
                return;
            }
        }


    }
}
