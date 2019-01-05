using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsW;
using GoodsMS.modle;
using GoodsMS.BAL;

namespace GoodsMS.UI
{
    public partial class GoodsMSopt : Form
    {
        public GoodsMSopt()
        {
            InitializeComponent();
        }

        public User user = new User();

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.UPDATE_GOODS_MSG) == 0)
            {
                MessageBox.Show("无修改货物表权限");
                return;
            }
            FormAddGoods form = new FormAddGoods();
            form.Show();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.SELECT_GOODS_MSG) == 0)
            {
                MessageBox.Show("无查询货物表权限");
                return;
            }
            FormShowGoodsMsg form = new FormShowGoodsMsg();
            form.Show();
        }

        private void btn_del_change_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.UPDATE_GOODS_MSG) == 0)
            {
                MessageBox.Show("无修改货物表权限");
                return;
            }
            FormUpdateGoodsMsg form = new FormUpdateGoodsMsg();
            form.Show();
        }

        private void btnEasyGoodsInOut_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.COME_GOODS_MSG) == 0
                || PowerManager.get_bit(user.Type, (int)PowerManager.power.ENTRY_GOODS_MSG) == 0)
            {
                MessageBox.Show("无修改货物进出仓权限");
                return;
            }
            FormGoodsInOutOpt form = new FormGoodsInOutOpt();
            form.Show();

        }

        private void btnComGoodsInOut_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.COME_GOODS_MSG) == 0
                || PowerManager.get_bit(user.Type, (int)PowerManager.power.ENTRY_GOODS_MSG) == 0)
            {
                MessageBox.Show("无修改货物进出仓权限");
                return;
            }
            FormUpdateMulGoodsMsg form = new FormUpdateMulGoodsMsg();
            form.user = user;
            form.Show();
        }

        private void GoodsMSopt_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.BUILD_REPORT) == 0)
            {
                MessageBox.Show("无生成报表权限");
                return;
            }
            FormReportView form = new FormReportView();
            form.Show();
        }

        private void btn_localtest_Click(object sender, EventArgs e)
        {

        }
    }
}
