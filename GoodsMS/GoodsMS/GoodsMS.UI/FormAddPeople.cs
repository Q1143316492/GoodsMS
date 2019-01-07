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
using System.Collections;

namespace GoodsMS.UI
{
    public partial class FormAddPeople : Form
    {
        public FormAddPeople()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认添加", "确认添加?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
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
                MessageBox.Show("插入数据不完整");
                return;
            }

            User user = new User();
            user.Userid = people.Userid;
            user.Username = people.Userid;
            user.Password = "123456";
            user.Type = PowerManager.DEFAULT_POWER.ToString();

            ArrayList arr = new ArrayList();
            arr.Add(PeopleMSHelper.Add_people_msgstr(people));
            arr.Add(PeopleMSHelper.Add_user_by_UserMsgstr(user));

            if (PeopleMSHelper.Add_people_msg(arr) == true)
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败");
            }
        }

        private void FormAddPeople_Load(object sender, EventArgs e)
        {

        }
    }
}
