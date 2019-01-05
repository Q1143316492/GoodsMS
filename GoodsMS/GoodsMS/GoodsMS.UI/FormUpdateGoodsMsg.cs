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
    public partial class FormUpdateGoodsMsg : Form
    {
        public FormUpdateGoodsMsg()
        {
            InitializeComponent();
        }

        private void FormUpdateGoodsMsg_Load(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
            dgv_peo.ReadOnly = true;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
        }

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (txt_goodsid.Text.Length == 0)
            {
                return;
            }
            Goods goods = new Goods();
            goods = GoodsMSHelper.Select_goods_by_goodsId(txt_goodsid.Text.Trim());
            if (goods != null)
            {
                txt_goodsname.Text = goods.Goods_name;
                txt_goodsSize.Text = goods.Goods_size;
                txt_GoodsUnit.Text = goods.Goods_unit;
                txt_GoodsNum.Text = goods.Goods_num;
                txt_other.Text = goods.Others;
            }
            else
            {
                MessageBox.Show("不存在该编号的物品");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除", "确认删除?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            if (GoodsMSHelper.Del_goods_by_goodsId(txt_goodsid.Text.Trim()))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改", "确认修改?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            Goods goods = new Goods();
            goods.Goods_id = txt_goodsid.Text.Trim();
            goods.Goods_name = txt_goodsname.Text.Trim();
            goods.Goods_size = txt_goodsSize.Text.Trim();
            goods.Goods_unit = txt_GoodsUnit.Text.Trim();
            goods.Goods_num = txt_GoodsNum.Text.Trim();
            goods.Others = txt_other.Text.Trim();
            if (goods.Check_Msg_Complete() == false)
            {
                MessageBox.Show("修改填写的数据不完整");
                return;
            }
            if (GoodsMSHelper.Update_goods_msg(goods))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
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
            btn_select_Click(sender, e);
        }

        private void dgv_peo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
