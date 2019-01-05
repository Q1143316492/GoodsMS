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
    public partial class FormUpdateMulGoodsMsg : Form
    {
        public FormUpdateMulGoodsMsg()
        {
            InitializeComponent();
        }

        List<KeyValuePair<GoodsMenu, int> > list = new List<KeyValuePair<GoodsMenu, int> >();

        public User user = null;
        int menu_list_count = 0;

        private void btn_go_Click(object sender, EventArgs e)
        {
            string txt = txt_input.Text.Trim();
            string tableName = "goods";
            string cmd = string.Format("select {0} from {1} where goods_name like '%{2}%'", DBhelper.get_select_string(tableName), tableName, txt);
            DataTable dt = SystemHelper.getTableBySql(cmd, tableName);
            dgv_peo.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("数据库中无匹配结果");
            }
        }

        private void FormUpdateMulGoodsMsg_Load(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
            dgv_peo.ReadOnly = true;

            this.btn_fresh_Click(sender, e);

            txt_menuid.ReadOnly = true;

            dt_opttime.Value = DateTime.Now;

            list.Clear();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!Checker.Check_Number(txt_optnum.Text.Trim(), false))
            {
                MessageBox.Show("数量输入不正确");
                return;
            }
            if (cbx_tp.SelectedIndex == -1)
            {
                MessageBox.Show("未选择操作类型");
                return;
            }
            GoodsMenu menu = new GoodsMenu();

            txt_menuid.Text = UpdateMulGoodsHelper.get_menu_id(user, dt_opttime.Value, ++menu_list_count);
            menu.MenuId = txt_menuid.Text.Trim();
            menu.Date = dt_opttime.Value;
            menu.OptPeopleId = user.Userid;
            menu.TxtMsg = txt_msg.Text.Trim();
            menu.Number = txt_optnum.Text.Trim();
            menu.Goods = GoodsMSHelper.Select_goods_by_goodsId(txt_goodsid.Text.Trim());

            if (menu.Goods == null)
            {
                MessageBox.Show("记录中不存在该货物");
                return;
            }

            list.Add(new KeyValuePair<GoodsMenu, int>(menu, cbx_tp.SelectedIndex));
            lis_menu.Items.Add(UpdateMulGoodsHelper.add_list_message(menu, cbx_tp.SelectedIndex));

            this.btn_fresh_Click(sender, e);
        }

        private void btn_clear_list_Click(object sender, EventArgs e)
        {
            list.Clear();
            lis_menu.Items.Clear();
        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            dt_opttime.Value = DateTime.Now;
            txt_menuid.Text = UpdateMulGoodsHelper.get_menu_id(user, dt_opttime.Value, ++menu_list_count);
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认提交?", "确认提交?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            ArrayList arr = new ArrayList();
            foreach (KeyValuePair<GoodsMenu, int> x in list)
            {
                GoodsMenu menu = x.Key;
                int type = x.Value;
                string cmd1 = "", cmd2 = "";
                if (type == 0)  // in
                {
                    cmd1 = GoodsMSHelper.entry_goods(menu);
                    cmd2 = GoodsMSHelper.Update_goods_number(menu.Goods, menu.Number, 0);
                }
                else if(type == 1) // out
                {
                    cmd1 = GoodsMSHelper.come_goods(menu);
                    cmd2 = GoodsMSHelper.Update_goods_number(menu.Goods, menu.Number, 1);
                }
                arr.Add(cmd1);
                arr.Add(cmd2);
            }
            if (arr.Count == 0)
            {
                MessageBox.Show("订单为空");
                return;
            }
            if (GoodsMSHelper.multy_post_menu(arr))
            {
                MessageBox.Show("操作提交成功");
                lis_menu.Items.Clear();
                list.Clear();
            }
            else
            {
                MessageBox.Show("操作提交失败");
            }
        }

        private void dgv_peo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_id = e.RowIndex;
            int col_id = e.ColumnIndex;
            string goods_id = "";
            if (row_id >= 0)
            {
                goods_id = dgv_peo.Rows[row_id].Cells[0].Value.ToString();
            }
            txt_goodsid.Text = goods_id;
        }

        ///delete one line from the menu
        private void lis_menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fresh_menu_by_del_line();
        }

        private void btn_delline_Click(object sender, EventArgs e)
        {
            fresh_menu_by_del_line();
        }

        private void fresh_menu_by_del_line()
        {
            if (lis_menu.SelectedItem == null)
            {
                return;
            }
            if (MessageBox.Show("确认删除这一项?", "确认删除这一项?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            var arr = lis_menu.SelectedItem.ToString().Split(' ');
            string good_id = arr[0];
            string good_num = arr[3];
            if (!Checker.Check_Number(good_num))
            {
                MessageBox.Show("库存修改数值错误");
                return;
            }
                
            foreach (var x in list)
            {
                if (x.Key.Goods.Goods_id.Equals(good_id) && x.Key.Number.Equals(good_num))
                {
                    list.Remove(x);

                    string tmp = UpdateMulGoodsHelper.add_list_message(x.Key, x.Value);
                    lis_menu.Items.Remove(UpdateMulGoodsHelper.add_list_message(x.Key, x.Value));
                    break;
                }
            }
        }

    }
}
