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
    public partial class FormUpdatePeoPleMsg : Form
    {
        public FormUpdatePeoPleMsg()
        {
            InitializeComponent();
        }

        private void FormUpdateMsg_Load(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("people");
            dgv_peo.ReadOnly = true;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            string txt = txt_input.Text.Trim();
            string tableName = "people";
            string cmd = string.Format("select {0} from {1} where username like '%{2}%'", DBhelper.get_select_string(tableName), tableName, txt);
            DataTable dt = SystemHelper.getTableBySql(cmd, tableName);
            dgv_peo.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("数据库中无匹配结果");
            }
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("people");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认用户信息?", "确认删除,注意删除后账号仍然存在?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            string userid = txt_usid.Text.Trim();
            if (PeopleMSHelper.Del_people_by_userid(userid))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            People people = new People();
            people = PeopleMSHelper.Select_people_by_usid(txt_usid.Text.Trim());
            if (people == null || people.Userid == null)
            {
                MessageBox.Show("请输入用户编号再点击选择");
                return;
            }
            txt_usid.Text = people.Userid;
            txt_usname.Text = people.Name;
            if (people.Sex.Equals("男"))
            {
                rbt_sex1.Checked = true;
            }
            else
            {
                rbtn_sex2.Checked = true;
            }
            dt_birth.Value = people.Birth;
            txt_idnumber.Text = people.Idnumber;
            txt_local.Text = people.Local;
            txt_home.Text = people.Home_address;
            txt_phone.Text = people.Phone;
            txt_other.Text = people.Other;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改", "确认修改?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
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
                MessageBox.Show("修改数据填写不完整");
                return;
            }
            if (PeopleMSHelper.Update_people_msg(people))
            {
                MessageBox.Show("修改成功");
                SystemHelper.getTable("people");
            }
            else
            {
                MessageBox.Show("修改失败");
            }

        }

        private void dgv_peo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btn_select_Click(sender, e);
        }

        private void dgv_peo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_id = e.RowIndex;
            int col_id = e.ColumnIndex;
            string userid = "";
            if (row_id >= 0)
            {
                userid = dgv_peo.Rows[row_id].Cells[0].Value.ToString();
            }
            txt_usid.Text = userid;
            btn_select_Click(sender, e);
        }

        private void dgv_peo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_peo_CellClick(sender, e);
            btn_select_Click(sender, e);
        }
    }
}
