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
using GoodsMS.DAL;

namespace GoodsMS.UI
{
    public partial class FormOptPower : Form
    {
        public FormOptPower()
        {
            InitializeComponent();
        }

        public User now_user = new User();

        private void FormOptPower_Load(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("sys_user");
            dgv_peo.ReadOnly = true;
            if (now_user.Username.Equals("admin") == false)
            {
                btn_localtest.Visible = false;
            }
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            string txt = txt_input.Text.Trim();
            string tableName = "sys_user";
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
            dgv_peo.DataSource = SystemHelper.getTable("sys_user");
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            User user = PeopleMSHelper.get_user_by_username(txt_username.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("选择失败");
                return;
            }
            if (user.Username.Equals("admin"))
            {
                MessageBox.Show("保留账号无法修改");
                txt_username.Text = "";
                return;
            }
            lis_pow_with.Items.Clear();
            lis_pow_without.Items.Clear();

            ArrayList arr_list_with = PowerManager.get_powerlist_by_power(user.Type);
            ArrayList arr_list_without = PowerManager.get_no_powerlist_by_power(user.Type);
            ArrayList now_power = PowerManager.get_powerlist_by_power(now_user.Type);

            foreach(var x in arr_list_without)
            {
                //MessageBox.Show("without" + (string)x);
                if (PowerManager.power_check(now_power, (string)x))
                {
                    lis_pow_without.Items.Add(x);
                }
            }
            foreach (var x in arr_list_with)
            {
                //MessageBox.Show("with" + (string)x);
                if (PowerManager.power_check(now_power, (string)x))
                {
                    lis_pow_with.Items.Add(x);
                }
            }

        }

        private void btn_get_pow_Click(object sender, EventArgs e)
        {
            if (lis_pow_without.SelectedIndex == -1)
            {
                return ;
            }
            string message = lis_pow_without.SelectedItem.ToString();
            lis_pow_without.Items.Remove(message);
            lis_pow_with.Items.Add(message);
        }

        private void btn_remove_pow_Click(object sender, EventArgs e)
        {
            if (lis_pow_with.SelectedIndex == -1)
            {
                return;
            }
            string message = lis_pow_with.SelectedItem.ToString();
            lis_pow_with.Items.Remove(message);
            lis_pow_without.Items.Add(message);
        }

        private void btn_post_pow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认提交?", "确认提交?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            ArrayList arr = new ArrayList();
            foreach (var it in lis_pow_with.Items)
            {
                arr.Add(it.ToString());
            }
            User user = PeopleMSHelper.get_user_by_username(txt_username.Text.Trim());
            if (user == null || user.Username.Equals("admin"))
            {
                MessageBox.Show("不存在用户，或用户无法修改");
                return;
            }
            if (PowerManager.update_power(arr, user))
            {
                MessageBox.Show("权限修改成功");
                return;
            }
            else
            {
                MessageBox.Show("权限修改失败");
                return;
            }
        }

        private void btn_deluser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除?", "确认删除?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (PowerManager.get_bit(now_user.Type, (int)PowerManager.power.DEL_USER) == 0)
            {
                MessageBox.Show("没有删除用户的权限");
                return;
            }
            User user = PeopleMSHelper.get_user_by_username(txt_username.Text.Trim());
            if (user == null || user.Username.Equals("admin"))
            {
                MessageBox.Show("不存在用户，或用户无法删除");
                return;
            }
            if (PeopleMSHelper.Delete_user_and_userMsg(user))
            {
                MessageBox.Show("删除成功");
                return;
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void dgv_peo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_id = e.RowIndex;
            int col_id = e.ColumnIndex;
            string username = "";
            if (row_id >= 0)
            {
                username = dgv_peo.Rows[row_id].Cells[0].Value.ToString();
            }
            txt_username.Text = username;
            btn_choose_Click(sender, e);
        }

        private void dgv_peo_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_peo.Rows.Count - 1; i++)
            {
                dgv_peo.Rows[i].Cells[1].Value = "******";
            }
        }

        //left to right
        private void lis_pow_without_DoubleClick(object sender, EventArgs e)
        {
            btn_get_pow_Click(sender, e);
        }

        //right to left
        private void lis_pow_with_DoubleClick(object sender, EventArgs e)
        {
            btn_remove_pow_Click(sender, e);
        }



    }
}
