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
    public partial class FormNewPSWD : Form
    {
        public FormNewPSWD()
        {
            InitializeComponent();
        }

        public User user = new User();

        private void FormNewPSWD_Load(object sender, EventArgs e)
        {
            txt_name.Text = user.Username;
            txt_name.Enabled = false;

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改", "确认修改?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (false == txt_pswdpre.Text.Trim().Equals(user.Password))
            {
                MessageBox.Show("原密码不正确");
                return;
            }
            string pswd1 = txt_pswd1.Text.Trim();
            string pswd2 = txt_pswd2.Text.Trim();
            if (pswd1.Equals(pswd2) == false)
            {
                MessageBox.Show("两次新密码不正确");
                return;
            }
            if (!Checker.Check_Password(pswd1))
            {
                MessageBox.Show("密码强度过低");
                return;
            }
            user.Password = pswd1;
            if (PeopleMSHelper.Update_User_msg(user))
            {
                MessageBox.Show("修改成功");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("修改失败");
                return;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
