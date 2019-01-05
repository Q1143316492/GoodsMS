namespace GoodsMS.UI
{
    partial class GoodsMSopt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsMSopt));
            this.btn_del_change = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnEasyGoodsInOut = new System.Windows.Forms.Button();
            this.btnComGoodsInOut = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_del_change
            // 
            this.btn_del_change.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_del_change.Location = new System.Drawing.Point(23, 127);
            this.btn_del_change.Name = "btn_del_change";
            this.btn_del_change.Size = new System.Drawing.Size(208, 33);
            this.btn_del_change.TabIndex = 5;
            this.btn_del_change.Text = "更新货物信息";
            this.btn_del_change.UseVisualStyleBackColor = true;
            this.btn_del_change.Click += new System.EventHandler(this.btn_del_change_Click);
            // 
            // btn_query
            // 
            this.btn_query.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_query.Location = new System.Drawing.Point(23, 78);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(208, 33);
            this.btn_query.TabIndex = 4;
            this.btn_query.Text = "查询货物信息";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_add.Location = new System.Drawing.Point(23, 27);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(208, 33);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "添加货物信息";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnEasyGoodsInOut
            // 
            this.btnEasyGoodsInOut.Font = new System.Drawing.Font("宋体", 13F);
            this.btnEasyGoodsInOut.Location = new System.Drawing.Point(23, 178);
            this.btnEasyGoodsInOut.Name = "btnEasyGoodsInOut";
            this.btnEasyGoodsInOut.Size = new System.Drawing.Size(208, 33);
            this.btnEasyGoodsInOut.TabIndex = 6;
            this.btnEasyGoodsInOut.Text = "简易进出仓登记";
            this.btnEasyGoodsInOut.UseVisualStyleBackColor = true;
            this.btnEasyGoodsInOut.Click += new System.EventHandler(this.btnEasyGoodsInOut_Click);
            // 
            // btnComGoodsInOut
            // 
            this.btnComGoodsInOut.Font = new System.Drawing.Font("宋体", 13F);
            this.btnComGoodsInOut.Location = new System.Drawing.Point(23, 234);
            this.btnComGoodsInOut.Name = "btnComGoodsInOut";
            this.btnComGoodsInOut.Size = new System.Drawing.Size(208, 33);
            this.btnComGoodsInOut.TabIndex = 7;
            this.btnComGoodsInOut.Text = "详细进出仓登记";
            this.btnComGoodsInOut.UseVisualStyleBackColor = true;
            this.btnComGoodsInOut.Click += new System.EventHandler(this.btnComGoodsInOut_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_report.Location = new System.Drawing.Point(23, 290);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(208, 33);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "进出仓生成报表";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GoodsMSopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(794, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btnComGoodsInOut);
            this.Controls.Add(this.btnEasyGoodsInOut);
            this.Controls.Add(this.btn_del_change);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GoodsMSopt";
            this.Text = "货物登记管理";
            this.Load += new System.EventHandler(this.GoodsMSopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_del_change;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnEasyGoodsInOut;
        private System.Windows.Forms.Button btnComGoodsInOut;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}