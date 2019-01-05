namespace GoodsMS.UI
{
    partial class FormReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoodsMSDataSet = new GoodsMS.UI.GoodsMSDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new GoodsMS.UI.GoodsMSDataSetTableAdapters.goodsTableAdapter();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_sub = new System.Windows.Forms.Button();
            this.rv_main = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTableAdapter = new GoodsMS.UI.GoodsMSDataSetTableAdapters.reportTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.GoodsMSDataSet;
            // 
            // GoodsMSDataSet
            // 
            this.GoodsMSDataSet.DataSetName = "GoodsMSDataSet";
            this.GoodsMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.GoodsMSDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.Font = new System.Drawing.Font("宋体", 13F);
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "入库记录",
            "出库记录"});
            this.cbx_type.Location = new System.Drawing.Point(777, 33);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(153, 25);
            this.cbx_type.TabIndex = 0;
            // 
            // dtp_begin
            // 
            this.dtp_begin.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_begin.Location = new System.Drawing.Point(131, 30);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(200, 27);
            this.dtp_begin.TabIndex = 1;
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_end.Location = new System.Drawing.Point(457, 29);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 27);
            this.dtp_end.TabIndex = 2;
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_sub.Location = new System.Drawing.Point(1004, 30);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(130, 28);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "生成报表";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // rv_main
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportBindingSource;
            this.rv_main.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_main.LocalReport.ReportEmbeddedResource = "GoodsMS.UI.Report1.rdlc";
            this.rv_main.Location = new System.Drawing.Point(27, 86);
            this.rv_main.Name = "rv_main";
            this.rv_main.Size = new System.Drawing.Size(1135, 517);
            this.rv_main.TabIndex = 4;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "开始时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(362, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(691, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "报表类型";
            // 
            // FormReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_main);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_begin);
            this.Controls.Add(this.cbx_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReportView";
            this.Text = "生成报表";
            this.Load += new System.EventHandler(this.FormReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource goodsBindingSource;
        private GoodsMSDataSet GoodsMSDataSet;
        private GoodsMSDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_sub;
        private Microsoft.Reporting.WinForms.ReportViewer rv_main;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private GoodsMSDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}