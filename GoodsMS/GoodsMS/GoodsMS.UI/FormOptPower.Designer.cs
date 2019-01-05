namespace GoodsMS.UI
{
    partial class FormOptPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptPower));
            this.dgv_peo = new System.Windows.Forms.DataGridView();
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_choose = new System.Windows.Forms.Button();
            this.lis_pow_without = new System.Windows.Forms.ListBox();
            this.lis_pow_with = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_get_pow = new System.Windows.Forms.Button();
            this.btn_remove_pow = new System.Windows.Forms.Button();
            this.btn_post_pow = new System.Windows.Forms.Button();
            this.btn_deluser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_localtest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_peo
            // 
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(12, 69);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(997, 129);
            this.dgv_peo.TabIndex = 19;
            this.dgv_peo.DataSourceChanged += new System.EventHandler(this.dgv_peo_DataSourceChanged);
            this.dgv_peo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellClick);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(851, 21);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(107, 29);
            this.btn_showall.TabIndex = 18;
            this.btn_showall.Text = "显示全部";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_go.Location = new System.Drawing.Point(717, 21);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(107, 29);
            this.btn_go.TabIndex = 17;
            this.btn_go.Text = "模糊查询";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_input.Location = new System.Drawing.Point(216, 24);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(471, 27);
            this.txt_input.TabIndex = 16;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(34, 27);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(179, 18);
            this.lab_name.TabIndex = 15;
            this.lab_name.Text = "用户名模糊匹配查询:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_username.Location = new System.Drawing.Point(216, 219);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(162, 27);
            this.txt_username.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(34, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "选中用户用户名:";
            // 
            // btn_choose
            // 
            this.btn_choose.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_choose.Location = new System.Drawing.Point(408, 219);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(107, 29);
            this.btn_choose.TabIndex = 22;
            this.btn_choose.Text = "选中";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // lis_pow_without
            // 
            this.lis_pow_without.Font = new System.Drawing.Font("宋体", 13F);
            this.lis_pow_without.FormattingEnabled = true;
            this.lis_pow_without.ItemHeight = 17;
            this.lis_pow_without.Location = new System.Drawing.Point(37, 306);
            this.lis_pow_without.Name = "lis_pow_without";
            this.lis_pow_without.Size = new System.Drawing.Size(176, 259);
            this.lis_pow_without.TabIndex = 23;
            // 
            // lis_pow_with
            // 
            this.lis_pow_with.Font = new System.Drawing.Font("宋体", 13F);
            this.lis_pow_with.FormattingEnabled = true;
            this.lis_pow_with.ItemHeight = 17;
            this.lis_pow_with.Location = new System.Drawing.Point(356, 306);
            this.lis_pow_with.Name = "lis_pow_with";
            this.lis_pow_with.Size = new System.Drawing.Size(176, 259);
            this.lis_pow_with.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "可以给予的权限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(353, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "已有权限";
            // 
            // btn_get_pow
            // 
            this.btn_get_pow.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_get_pow.Location = new System.Drawing.Point(235, 364);
            this.btn_get_pow.Name = "btn_get_pow";
            this.btn_get_pow.Size = new System.Drawing.Size(94, 28);
            this.btn_get_pow.TabIndex = 27;
            this.btn_get_pow.Text = "获得>>";
            this.btn_get_pow.UseVisualStyleBackColor = true;
            this.btn_get_pow.Click += new System.EventHandler(this.btn_get_pow_Click);
            // 
            // btn_remove_pow
            // 
            this.btn_remove_pow.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_remove_pow.Location = new System.Drawing.Point(235, 423);
            this.btn_remove_pow.Name = "btn_remove_pow";
            this.btn_remove_pow.Size = new System.Drawing.Size(94, 28);
            this.btn_remove_pow.TabIndex = 28;
            this.btn_remove_pow.Text = "去除<<";
            this.btn_remove_pow.UseVisualStyleBackColor = true;
            this.btn_remove_pow.Click += new System.EventHandler(this.btn_remove_pow_Click);
            // 
            // btn_post_pow
            // 
            this.btn_post_pow.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_post_pow.Location = new System.Drawing.Point(851, 219);
            this.btn_post_pow.Name = "btn_post_pow";
            this.btn_post_pow.Size = new System.Drawing.Size(107, 29);
            this.btn_post_pow.TabIndex = 29;
            this.btn_post_pow.Text = "提交修改";
            this.btn_post_pow.UseVisualStyleBackColor = true;
            this.btn_post_pow.Click += new System.EventHandler(this.btn_post_pow_Click);
            // 
            // btn_deluser
            // 
            this.btn_deluser.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_deluser.Location = new System.Drawing.Point(717, 219);
            this.btn_deluser.Name = "btn_deluser";
            this.btn_deluser.Size = new System.Drawing.Size(107, 29);
            this.btn_deluser.TabIndex = 30;
            this.btn_deluser.Text = "删除用户";
            this.btn_deluser.UseVisualStyleBackColor = true;
            this.btn_deluser.Click += new System.EventHandler(this.btn_deluser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_localtest
            // 
            this.btn_localtest.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_localtest.Location = new System.Drawing.Point(580, 219);
            this.btn_localtest.Name = "btn_localtest";
            this.btn_localtest.Size = new System.Drawing.Size(107, 29);
            this.btn_localtest.TabIndex = 32;
            this.btn_localtest.Text = "测试";
            this.btn_localtest.UseVisualStyleBackColor = true;
            // 
            // FormOptPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 591);
            this.Controls.Add(this.btn_localtest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_deluser);
            this.Controls.Add(this.btn_post_pow);
            this.Controls.Add(this.btn_remove_pow);
            this.Controls.Add(this.btn_get_pow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lis_pow_with);
            this.Controls.Add(this.lis_pow_without);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.dgv_peo);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOptPower";
            this.Text = "权限控制";
            this.Load += new System.EventHandler(this.FormOptPower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_peo;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.ListBox lis_pow_without;
        private System.Windows.Forms.ListBox lis_pow_with;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_get_pow;
        private System.Windows.Forms.Button btn_remove_pow;
        private System.Windows.Forms.Button btn_post_pow;
        private System.Windows.Forms.Button btn_deluser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_localtest;
    }
}