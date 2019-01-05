namespace GoodsMS.UI
{
    partial class FormRegister
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
            this.txt_pswd1 = new System.Windows.Forms.TextBox();
            this.lab_uspswd = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_usname = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_pswd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_pswd1
            // 
            this.txt_pswd1.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_pswd1.Location = new System.Drawing.Point(165, 104);
            this.txt_pswd1.Name = "txt_pswd1";
            this.txt_pswd1.PasswordChar = '*';
            this.txt_pswd1.Size = new System.Drawing.Size(186, 27);
            this.txt_pswd1.TabIndex = 7;
            // 
            // lab_uspswd
            // 
            this.lab_uspswd.AutoSize = true;
            this.lab_uspswd.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_uspswd.Location = new System.Drawing.Point(41, 107);
            this.lab_uspswd.Name = "lab_uspswd";
            this.lab_uspswd.Size = new System.Drawing.Size(107, 18);
            this.lab_uspswd.TabIndex = 6;
            this.lab_uspswd.Text = "请输入密码:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_name.Location = new System.Drawing.Point(165, 53);
            this.txt_name.MaxLength = 10;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(186, 27);
            this.txt_name.TabIndex = 5;
            // 
            // lab_usname
            // 
            this.lab_usname.AutoSize = true;
            this.lab_usname.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usname.Location = new System.Drawing.Point(57, 56);
            this.lab_usname.Name = "lab_usname";
            this.lab_usname.Size = new System.Drawing.Size(71, 18);
            this.lab_usname.TabIndex = 4;
            this.lab_usname.Text = "用户名:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_exit.Location = new System.Drawing.Point(214, 207);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(92, 29);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_register.Location = new System.Drawing.Point(75, 207);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(92, 29);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_pswd2
            // 
            this.txt_pswd2.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_pswd2.Location = new System.Drawing.Point(165, 151);
            this.txt_pswd2.MaxLength = 10;
            this.txt_pswd2.Name = "txt_pswd2";
            this.txt_pswd2.PasswordChar = '*';
            this.txt_pswd2.Size = new System.Drawing.Size(186, 27);
            this.txt_pswd2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(41, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "再次输入密码:";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 270);
            this.Controls.Add(this.txt_pswd2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_pswd1);
            this.Controls.Add(this.lab_uspswd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_usname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRegister";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pswd1;
        private System.Windows.Forms.Label lab_uspswd;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_usname;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_pswd2;
        private System.Windows.Forms.Label label1;
    }
}