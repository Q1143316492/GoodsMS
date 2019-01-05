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
    public partial class PeopleMSopt : Form
    {
        public PeopleMSopt()
        {
            InitializeComponent();
        }

        public User user = new User();

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type ,(int)PowerManager.power.UPDATE_PEOPLE_MSG) == 0)
            {
                MessageBox.Show("无添加角色信息权限");
                return;
            }
            FormAddPeople form = new FormAddPeople();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.SELECT_PEOPLE_MSG) == 0)
            {
                MessageBox.Show("无查询角色信息权限");
                return;
            }
            FormShowPeoMsg form = new FormShowPeoMsg();
            form.Show();
        }

        private void btn_del_change_Click(object sender, EventArgs e)
        {
            if (PowerManager.get_bit(user.Type, (int)PowerManager.power.UPDATE_PEOPLE_MSG) == 0)
            {
                MessageBox.Show("无更新角色信息权限");
                return;
            }
            FormUpdatePeoPleMsg form = new FormUpdatePeoPleMsg();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MulTran.multiple_trans_test())
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void PeopleMSopt_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_mymsg_Click(object sender, EventArgs e)
        {
            FormAddPersonalMsg form = new FormAddPersonalMsg();
            form.user = user;
            form.Show();
        }

    }
}
