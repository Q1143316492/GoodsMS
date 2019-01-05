namespace GoodsMS.UI
{
    partial class FormUpdatePeoPleMsg
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
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.dgv_peo = new System.Windows.Forms.DataGridView();
            this.lab_usid = new System.Windows.Forms.Label();
            this.txt_usid = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.lab_other = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_home = new System.Windows.Forms.TextBox();
            this.lab_home = new System.Windows.Forms.Label();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.lab_local = new System.Windows.Forms.Label();
            this.txt_idnumber = new System.Windows.Forms.TextBox();
            this.lab_idnum = new System.Windows.Forms.Label();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
            this.lab_birth = new System.Windows.Forms.Label();
            this.rbtn_sex2 = new System.Windows.Forms.RadioButton();
            this.rbt_sex1 = new System.Windows.Forms.RadioButton();
            this.lab_sex = new System.Windows.Forms.Label();
            this.txt_usname = new System.Windows.Forms.TextBox();
            this.lab_usname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(850, 18);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(107, 29);
            this.btn_showall.TabIndex = 8;
            this.btn_showall.Text = "显示全部";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_go.Location = new System.Drawing.Point(716, 18);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(107, 29);
            this.btn_go.TabIndex = 7;
            this.btn_go.Text = "模糊查询";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_input.Location = new System.Drawing.Point(215, 21);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(471, 27);
            this.txt_input.TabIndex = 6;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(33, 24);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(161, 18);
            this.lab_name.TabIndex = 5;
            this.lab_name.Text = "姓名模糊匹配查询:";
            // 
            // dgv_peo
            // 
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(35, 71);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(922, 146);
            this.dgv_peo.TabIndex = 9;
            this.dgv_peo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellClick);
            this.dgv_peo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellContentClick);
            this.dgv_peo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellDoubleClick);
            // 
            // lab_usid
            // 
            this.lab_usid.AutoSize = true;
            this.lab_usid.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usid.Location = new System.Drawing.Point(32, 249);
            this.lab_usid.Name = "lab_usid";
            this.lab_usid.Size = new System.Drawing.Size(89, 18);
            this.lab_usid.TabIndex = 10;
            this.lab_usid.Text = "人员代码:";
            // 
            // txt_usid
            // 
            this.txt_usid.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_usid.Location = new System.Drawing.Point(143, 246);
            this.txt_usid.Name = "txt_usid";
            this.txt_usid.Size = new System.Drawing.Size(184, 27);
            this.txt_usid.TabIndex = 11;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_del.Location = new System.Drawing.Point(552, 244);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(145, 29);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "删除该用户信息";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_select.Location = new System.Drawing.Point(375, 243);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(145, 29);
            this.btn_select.TabIndex = 13;
            this.btn_select.Text = "选择用户";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_update.Location = new System.Drawing.Point(725, 244);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 29);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "提交修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_other
            // 
            this.txt_other.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_other.Location = new System.Drawing.Point(143, 456);
            this.txt_other.Multiline = true;
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(792, 79);
            this.txt_other.TabIndex = 37;
            // 
            // lab_other
            // 
            this.lab_other.AutoSize = true;
            this.lab_other.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_other.Location = new System.Drawing.Point(33, 456);
            this.lab_other.Name = "lab_other";
            this.lab_other.Size = new System.Drawing.Size(53, 18);
            this.lab_other.TabIndex = 36;
            this.lab_other.Text = "备注:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_phone.Location = new System.Drawing.Point(143, 401);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(184, 27);
            this.txt_phone.TabIndex = 35;
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_phone.Location = new System.Drawing.Point(33, 404);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(89, 18);
            this.lab_phone.TabIndex = 34;
            this.lab_phone.Text = "联系电话:";
            // 
            // txt_home
            // 
            this.txt_home.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_home.Location = new System.Drawing.Point(768, 349);
            this.txt_home.Name = "txt_home";
            this.txt_home.Size = new System.Drawing.Size(167, 27);
            this.txt_home.TabIndex = 33;
            // 
            // lab_home
            // 
            this.lab_home.AutoSize = true;
            this.lab_home.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_home.Location = new System.Drawing.Point(664, 352);
            this.lab_home.Name = "lab_home";
            this.lab_home.Size = new System.Drawing.Size(89, 18);
            this.lab_home.TabIndex = 32;
            this.lab_home.Text = "家庭住址:";
            // 
            // txt_local
            // 
            this.txt_local.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_local.Location = new System.Drawing.Point(465, 349);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(167, 27);
            this.txt_local.TabIndex = 31;
            // 
            // lab_local
            // 
            this.lab_local.AutoSize = true;
            this.lab_local.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_local.Location = new System.Drawing.Point(372, 352);
            this.lab_local.Name = "lab_local";
            this.lab_local.Size = new System.Drawing.Size(53, 18);
            this.lab_local.TabIndex = 30;
            this.lab_local.Text = "籍贯:";
            // 
            // txt_idnumber
            // 
            this.txt_idnumber.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_idnumber.Location = new System.Drawing.Point(143, 349);
            this.txt_idnumber.Name = "txt_idnumber";
            this.txt_idnumber.Size = new System.Drawing.Size(184, 27);
            this.txt_idnumber.TabIndex = 29;
            // 
            // lab_idnum
            // 
            this.lab_idnum.AutoSize = true;
            this.lab_idnum.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_idnum.Location = new System.Drawing.Point(33, 352);
            this.lab_idnum.Name = "lab_idnum";
            this.lab_idnum.Size = new System.Drawing.Size(89, 18);
            this.lab_idnum.TabIndex = 28;
            this.lab_idnum.Text = "身份证号:";
            // 
            // dt_birth
            // 
            this.dt_birth.Font = new System.Drawing.Font("宋体", 13F);
            this.dt_birth.Location = new System.Drawing.Point(465, 299);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(167, 27);
            this.dt_birth.TabIndex = 27;
            // 
            // lab_birth
            // 
            this.lab_birth.AutoSize = true;
            this.lab_birth.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_birth.Location = new System.Drawing.Point(372, 302);
            this.lab_birth.Name = "lab_birth";
            this.lab_birth.Size = new System.Drawing.Size(53, 18);
            this.lab_birth.TabIndex = 26;
            this.lab_birth.Text = "生日:";
            // 
            // rbtn_sex2
            // 
            this.rbtn_sex2.AutoSize = true;
            this.rbtn_sex2.Font = new System.Drawing.Font("宋体", 13F);
            this.rbtn_sex2.Location = new System.Drawing.Point(793, 298);
            this.rbtn_sex2.Name = "rbtn_sex2";
            this.rbtn_sex2.Size = new System.Drawing.Size(44, 22);
            this.rbtn_sex2.TabIndex = 25;
            this.rbtn_sex2.TabStop = true;
            this.rbtn_sex2.Text = "女";
            this.rbtn_sex2.UseVisualStyleBackColor = true;
            // 
            // rbt_sex1
            // 
            this.rbt_sex1.AutoSize = true;
            this.rbt_sex1.Font = new System.Drawing.Font("宋体", 13F);
            this.rbt_sex1.Location = new System.Drawing.Point(725, 299);
            this.rbt_sex1.Name = "rbt_sex1";
            this.rbt_sex1.Size = new System.Drawing.Size(44, 22);
            this.rbt_sex1.TabIndex = 24;
            this.rbt_sex1.TabStop = true;
            this.rbt_sex1.Text = "男";
            this.rbt_sex1.UseVisualStyleBackColor = true;
            // 
            // lab_sex
            // 
            this.lab_sex.AutoSize = true;
            this.lab_sex.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_sex.Location = new System.Drawing.Point(664, 302);
            this.lab_sex.Name = "lab_sex";
            this.lab_sex.Size = new System.Drawing.Size(53, 18);
            this.lab_sex.TabIndex = 23;
            this.lab_sex.Text = "性别:";
            // 
            // txt_usname
            // 
            this.txt_usname.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_usname.Location = new System.Drawing.Point(143, 299);
            this.txt_usname.Name = "txt_usname";
            this.txt_usname.Size = new System.Drawing.Size(184, 27);
            this.txt_usname.TabIndex = 22;
            // 
            // lab_usname
            // 
            this.lab_usname.AutoSize = true;
            this.lab_usname.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usname.Location = new System.Drawing.Point(33, 302);
            this.lab_usname.Name = "lab_usname";
            this.lab_usname.Size = new System.Drawing.Size(89, 18);
            this.lab_usname.TabIndex = 21;
            this.lab_usname.Text = "用户姓名:";
            // 
            // FormUpdatePeoPleMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.txt_other);
            this.Controls.Add(this.lab_other);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_home);
            this.Controls.Add(this.lab_home);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.lab_local);
            this.Controls.Add(this.txt_idnumber);
            this.Controls.Add(this.lab_idnum);
            this.Controls.Add(this.dt_birth);
            this.Controls.Add(this.lab_birth);
            this.Controls.Add(this.rbtn_sex2);
            this.Controls.Add(this.rbt_sex1);
            this.Controls.Add(this.lab_sex);
            this.Controls.Add(this.txt_usname);
            this.Controls.Add(this.lab_usname);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_usid);
            this.Controls.Add(this.lab_usid);
            this.Controls.Add(this.dgv_peo);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormUpdatePeoPleMsg";
            this.Text = "更新用户信息";
            this.Load += new System.EventHandler(this.FormUpdateMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.DataGridView dgv_peo;
        private System.Windows.Forms.Label lab_usid;
        private System.Windows.Forms.TextBox txt_usid;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.Label lab_other;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_home;
        private System.Windows.Forms.Label lab_home;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label lab_local;
        private System.Windows.Forms.TextBox txt_idnumber;
        private System.Windows.Forms.Label lab_idnum;
        private System.Windows.Forms.DateTimePicker dt_birth;
        private System.Windows.Forms.Label lab_birth;
        private System.Windows.Forms.RadioButton rbtn_sex2;
        private System.Windows.Forms.RadioButton rbt_sex1;
        private System.Windows.Forms.Label lab_sex;
        private System.Windows.Forms.TextBox txt_usname;
        private System.Windows.Forms.Label lab_usname;
    }
}