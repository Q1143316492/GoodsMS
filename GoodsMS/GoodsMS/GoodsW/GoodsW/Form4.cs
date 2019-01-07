using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoodsW
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SystemDBhelper.getTable("goods");
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string tablename = "goods";
            string cmd = string.Format("select * from {0} where goods_id like '%{1}%'",tablename,name);
            DataTable dt = SystemDBhelper.getTableBySql(cmd, tablename);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("数据库中无匹配结果");
            }
        }
    }
}
