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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entry enn = new entry();
            enn.Entryid = entryid.Text.Trim();
            enn.Peopleid = peopleid.Text.Trim();
            enn.Goodsid = goodsid.Text.Trim();
            enn.Entrytime = entrytime.Value;
            enn.Entrynumber = int.Parse(entrynumber.Text);
            enn.Text1 = text1.Text.Trim();
            if (entryhelper.goods(enn))
            {
                MessageBox.Show("进仓成功!");
            }
            else
            {
                MessageBox.Show("进仓失败!"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
