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
    public partial class FormReportView : Form
    {
        public FormReportView()
        {
            InitializeComponent();
        }

        private void FormReportView_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GoodsMSDataSet.report”中。您可以根据需要移动或删除它。
            //this.reportTableAdapter.Fill(this.GoodsMSDataSet.report);
            // TODO: 这行代码将数据加载到表“GoodsMSDataSet.report”中。您可以根据需要移动或删除它。
            //this.reportTableAdapter.Fill(this.GoodsMSDataSet.report);
            //this.rv_main.RefreshReport();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            DateTime dt_begin = dtp_begin.Value.ToLocalTime();
            DateTime dt_end = dtp_end.Value.ToLocalTime();
            if (cbx_type.SelectedIndex == -1)
            {
                return;
            }
            if (cbx_type.SelectedIndex == 0)
            {
                ReportManager.init_entry_report(dt_begin, dt_end);
            }
            else if(cbx_type.SelectedIndex == 1)
            {
                ReportManager.init_come_report(dt_begin, dt_end);
            }
            this.reportTableAdapter.Fill(this.GoodsMSDataSet.report);
            this.rv_main.RefreshReport();
        }


    }
}
