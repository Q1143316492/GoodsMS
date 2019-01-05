using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsMS.BAL;
using GoodsMS.modle;

namespace GoodsMS.UI
{
    public partial class FormAddPersonalMsg : Form
    {
        public FormAddPersonalMsg()
        {
            InitializeComponent();
        }

        public User user = new User();

        private void FormAddPersonalMsg_Load(object sender, EventArgs e)
        {
            txt_usid.ReadOnly = true;
            txt_usid.Text = user.Userid;
            People peo = PeopleMSHelper.Select_people_by_usid(user.Userid);

            init_msg(peo);

        }

        private void init_msg(People peo)
        {
            if (peo == null)
            {
                return;
            }
            txt_usname.Text = peo.Name;
            if (peo.Sex.Equals("男"))
            {
                rbt_sex1.Checked = true;
            }
            else
            {
                rbtn_sex2.Checked = true;
            }
            dt_birth.Value = peo.Birth;
            txt_idnumber.Text = peo.Idnumber;
            txt_local.Text = peo.Local;
            txt_home.Text = peo.Home_address;
            txt_phone.Text = peo.Phone;
            txt_other.Text = peo.Other;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认更新", "确认更新?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (txt_usid.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户编号不能为空");
                return;
            }
            People people = new People();
            people.Userid = txt_usid.Text.Trim();
            people.Name = txt_usname.Text.Trim();
            people.Sex = rbt_sex1.Checked ? rbt_sex1.Text : rbtn_sex2.Text;
            people.Birth = dt_birth.Value;
            people.Idnumber = txt_idnumber.Text.Trim();
            people.Local = txt_local.Text.Trim();
            people.Home_address = txt_home.Text.Trim();
            people.Phone = txt_phone.Text.Trim();
            people.Other = txt_other.Text.Trim();
            if (people.Check_Msg_Complete() == false)
            {
                MessageBox.Show("数据不完整");
                return;
            }
            if (PeopleMSHelper.Add_people_msg(people))
            {
                MessageBox.Show("修改成功");
                return;
            }
            if (PeopleMSHelper.Update_people_msg(people))
            {
                MessageBox.Show("更新成功");
                return;
            }
            MessageBox.Show("更新失败");

        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            People peo = PeopleMSHelper.Select_people_by_usid(user.Userid);
            init_msg(peo);
        }

        private void btn_changepswd_Click(object sender, EventArgs e)
        {
            FormNewPSWD form = new FormNewPSWD();
            form.user = user;
            form.Show();
        }
    }
}
