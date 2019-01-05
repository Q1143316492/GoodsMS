namespace GoodsMS.UI
{
    partial class FormUpdateMulGoodsMsg
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
            this.dgv_peo = new System.Windows.Forms.DataGridView();
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lis_menu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_menuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_opttime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_goodsid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_tp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_optnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear_list = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.btn_delline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_peo
            // 
            this.dgv_peo.AllowUserToAddRows = false;
            this.dgv_peo.AllowUserToDeleteRows = false;
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(18, 86);
            this.dgv_peo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.ReadOnly = true;
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(1280, 185);
            this.dgv_peo.TabIndex = 19;
            this.dgv_peo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellClick);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(1120, 18);
            this.btn_showall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(160, 41);
            this.btn_showall.TabIndex = 18;
            this.btn_showall.Text = "显示全部";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_go.Location = new System.Drawing.Point(938, 18);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(160, 41);
            this.btn_go.TabIndex = 17;
            this.btn_go.Text = "模糊查询";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_input.Location = new System.Drawing.Point(208, 23);
            this.txt_input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(704, 27);
            this.txt_input.TabIndex = 16;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(21, 26);
            this.lab_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(179, 18);
            this.lab_name.TabIndex = 15;
            this.lab_name.Text = "货物名模糊匹配查询:";
            // 
            // lis_menu
            // 
            this.lis_menu.FormattingEnabled = true;
            this.lis_menu.ItemHeight = 17;
            this.lis_menu.Location = new System.Drawing.Point(18, 298);
            this.lis_menu.Margin = new System.Windows.Forms.Padding(4);
            this.lis_menu.Name = "lis_menu";
            this.lis_menu.Size = new System.Drawing.Size(1280, 157);
            this.lis_menu.TabIndex = 20;
            this.lis_menu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lis_menu_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "本操作单号:";
            // 
            // txt_menuid
            // 
            this.txt_menuid.Location = new System.Drawing.Point(128, 483);
            this.txt_menuid.Name = "txt_menuid";
            this.txt_menuid.Size = new System.Drawing.Size(331, 27);
            this.txt_menuid.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "操作时间:";
            // 
            // dt_opttime
            // 
            this.dt_opttime.Font = new System.Drawing.Font("宋体", 13F);
            this.dt_opttime.Location = new System.Drawing.Point(128, 530);
            this.dt_opttime.Name = "dt_opttime";
            this.dt_opttime.Size = new System.Drawing.Size(167, 27);
            this.dt_opttime.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "物料代码:";
            // 
            // txt_goodsid
            // 
            this.txt_goodsid.Location = new System.Drawing.Point(426, 528);
            this.txt_goodsid.Name = "txt_goodsid";
            this.txt_goodsid.Size = new System.Drawing.Size(131, 27);
            this.txt_goodsid.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "操作类型:";
            // 
            // cbx_tp
            // 
            this.cbx_tp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tp.FormattingEnabled = true;
            this.cbx_tp.Items.AddRange(new object[] {
            "入库",
            "出库"});
            this.cbx_tp.Location = new System.Drawing.Point(696, 532);
            this.cbx_tp.Name = "cbx_tp";
            this.cbx_tp.Size = new System.Drawing.Size(121, 25);
            this.cbx_tp.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(838, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "修改数量:";
            // 
            // txt_optnum
            // 
            this.txt_optnum.Location = new System.Drawing.Point(951, 532);
            this.txt_optnum.Name = "txt_optnum";
            this.txt_optnum.Size = new System.Drawing.Size(131, 27);
            this.txt_optnum.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "备注：";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(128, 578);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(954, 63);
            this.txt_msg.TabIndex = 32;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(208, 664);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(175, 30);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "添加一条记录";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear_list
            // 
            this.btn_clear_list.Location = new System.Drawing.Point(475, 664);
            this.btn_clear_list.Name = "btn_clear_list";
            this.btn_clear_list.Size = new System.Drawing.Size(175, 30);
            this.btn_clear_list.TabIndex = 34;
            this.btn_clear_list.Text = "清空记录表";
            this.btn_clear_list.UseVisualStyleBackColor = true;
            this.btn_clear_list.Click += new System.EventHandler(this.btn_clear_list_Click);
            // 
            // btn_post
            // 
            this.btn_post.Location = new System.Drawing.Point(737, 664);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(175, 30);
            this.btn_post.TabIndex = 35;
            this.btn_post.Text = "提交订单";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_fresh
            // 
            this.btn_fresh.Location = new System.Drawing.Point(482, 483);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(101, 27);
            this.btn_fresh.TabIndex = 36;
            this.btn_fresh.Text = "刷新单号";
            this.btn_fresh.UseVisualStyleBackColor = true;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // btn_delline
            // 
            this.btn_delline.Location = new System.Drawing.Point(605, 483);
            this.btn_delline.Name = "btn_delline";
            this.btn_delline.Size = new System.Drawing.Size(152, 27);
            this.btn_delline.TabIndex = 37;
            this.btn_delline.Text = "删除选择行";
            this.btn_delline.UseVisualStyleBackColor = true;
            this.btn_delline.Click += new System.EventHandler(this.btn_delline_Click);
            // 
            // FormUpdateMulGoodsMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 722);
            this.Controls.Add(this.btn_delline);
            this.Controls.Add(this.btn_fresh);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_clear_list);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_optnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_tp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_goodsid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_opttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_menuid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lis_menu);
            this.Controls.Add(this.dgv_peo);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.Font = new System.Drawing.Font("宋体", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateMulGoodsMsg";
            this.Text = "批量进出仓";
            this.Load += new System.EventHandler(this.FormUpdateMulGoodsMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_peo;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.ListBox lis_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_menuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_opttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_goodsid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_tp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_optnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear_list;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_fresh;
        private System.Windows.Forms.Button btn_delline;
    }
}