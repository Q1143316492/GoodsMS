using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsMS.BAL;

namespace GoodsMS.UI
{
    public partial class FormShowGoodsMsg : Form
    {
        public FormShowGoodsMsg()
        {
            InitializeComponent();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
        }

        private void FormShowGoodsMsg_Load(object sender, EventArgs e)
        {
            dgv_peo.DataSource = SystemHelper.getTable("goods");
            dgv_peo.ReadOnly = true;
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
    }
}
