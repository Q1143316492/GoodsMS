namespace GoodsMS.UI
{
    partial class PeopleMSopt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleMSopt));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.btn_del_change = new System.Windows.Forms.Button();
            this.btn_mymsg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 43);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(188, 33);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加人员信息";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(12, 122);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(188, 33);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "查询人员信息";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_del_change
            // 
            this.btn_del_change.Location = new System.Drawing.Point(12, 196);
            this.btn_del_change.Name = "btn_del_change";
            this.btn_del_change.Size = new System.Drawing.Size(188, 33);
            this.btn_del_change.TabIndex = 2;
            this.btn_del_change.Text = "更新用户信息";
            this.btn_del_change.UseVisualStyleBackColor = true;
            this.btn_del_change.Click += new System.EventHandler(this.btn_del_change_Click);
            // 
            // btn_mymsg
            // 
            this.btn_mymsg.Location = new System.Drawing.Point(12, 274);
            this.btn_mymsg.Name = "btn_mymsg";
            this.btn_mymsg.Size = new System.Drawing.Size(188, 33);
            this.btn_mymsg.TabIndex = 3;
            this.btn_mymsg.Text = "个人信息修改";
            this.btn_mymsg.UseVisualStyleBackColor = true;
            this.btn_mymsg.Click += new System.EventHandler(this.btn_mymsg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PeopleMSopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(794, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_mymsg);
            this.Controls.Add(this.btn_del_change);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("宋体", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PeopleMSopt";
            this.Text = "人员登记管理";
            this.Load += new System.EventHandler(this.PeopleMSopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_del_change;
        private System.Windows.Forms.Button btn_mymsg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}