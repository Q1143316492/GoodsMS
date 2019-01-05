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
    public partial class FormAddGoods : Form
    {
        public FormAddGoods()
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
            if (txt_goodsid.Text.Trim().Length == 0)
            {
                MessageBox.Show("货物代码不能为空");
                return;
            }
            if (!Checker.Check_Number(txt_GoodsNum.Text.Trim())) 
            {
                MessageBox.Show("数量格式不正确");
                return;
            }
            Goods goods = new Goods();
            goods.Goods_id = txt_goodsid.Text.Trim();
            goods.Goods_name = txt_goodsname.Text.Trim();
            goods.Goods_size = txt_goodsSize.Text.Trim();
            goods.Goods_num = txt_GoodsNum.Text.Trim();
            goods.Goods_unit = txt_GoodsUnit.Text.Trim();
            goods.Others = txt_other.Text.Trim();
            if (goods.Check_Msg_Complete() == false)
            {
                MessageBox.Show("输入数据不完整");
                return;
            }
            if (GoodsMSHelper.Add_Goods_Msg(goods))
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败");
            }
        }

        private void FormAddGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
