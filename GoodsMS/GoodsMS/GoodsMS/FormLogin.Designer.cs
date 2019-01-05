namespace GoodsMS
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lab_usname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.lab_uspswd = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_usname
            // 
            this.lab_usname.AutoSize = true;
            this.lab_usname.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usname.Location = new System.Drawing.Point(76, 159);
            this.lab_usname.Name = "lab_usname";
            this.lab_usname.Size = new System.Drawing.Size(71, 18);
            this.lab_usname.TabIndex = 0;
            this.lab_usname.Text = "用户名:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_name.Location = new System.Drawing.Point(174, 156);
            this.txt_name.MaxLength = 10;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(338, 27);
            this.txt_name.TabIndex = 1;
            // 
            // txt_pswd
            // 
            this.txt_pswd.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_pswd.Location = new System.Drawing.Point(174, 206);
            this.txt_pswd.MaxLength = 10;
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.PasswordChar = '*';
            this.txt_pswd.Size = new System.Drawing.Size(338, 27);
            this.txt_pswd.TabIndex = 3;
            // 
            // lab_uspswd
            // 
            this.lab_uspswd.AutoSize = true;
            this.lab_uspswd.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_uspswd.Location = new System.Drawing.Point(76, 209);
            this.lab_uspswd.Name = "lab_uspswd";
            this.lab_uspswd.Size = new System.Drawing.Size(53, 18);
            this.lab_uspswd.TabIndex = 2;
            this.lab_uspswd.Text = "密码:";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_type.Location = new System.Drawing.Point(76, 261);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(89, 18);
            this.lab_type.TabIndex = 4;
            this.lab_type.Text = "登入类型:";
            // 
            // cbox_type
            // 
            this.cbox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_type.Font = new System.Drawing.Font("宋体", 13F);
            this.cbox_type.FormattingEnabled = true;
            this.cbox_type.Items.AddRange(new object[] {
            "1. 人员档案的管理",
            "2. 物料档案管理",
            "3. 权限控制管理"});
            this.cbox_type.Location = new System.Drawing.Point(174, 258);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(338, 25);
            this.cbox_type.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_login.Location = new System.Drawing.Point(144, 310);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 29);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_register.Location = new System.Drawing.Point(339, 310);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(92, 29);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cbox_type);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.lab_uspswd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_usname);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "登入";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_usname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.Label lab_uspswd;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

