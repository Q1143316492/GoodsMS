using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodsMS.BAL;

namespace GoodsW
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Checker.Check_Number(comenumber.Text.Trim()))
            {
                MessageBox.Show("数量格式不正确");
                return;
            }
            come coo = new come();
            coo.Comeid = comeid.Text.Trim();
            coo.Peopleid = peopleid.Text.Trim();
            coo.Goodsid = goodsid.Text.Trim();
            coo.Cometime = cometime.Value;
            coo.Comenumber = int.Parse(comenumber.Text);
            coo.Text2 = text2.Text.Trim();
            if (comehelper.come(coo))
            {
                MessageBox.Show("出仓成功!");
            }
            else
            {
                MessageBox.Show("出仓失败!");
            }
        }
    }
}
