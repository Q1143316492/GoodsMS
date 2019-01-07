namespace GoodsW
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.entryid = new System.Windows.Forms.TextBox();
            this.peopleid = new System.Windows.Forms.TextBox();
            this.goodsid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.entrytime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.entrynumber = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料进仓信息";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "进仓单号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "操作人员代码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "物料代码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "进仓时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // entryid
            // 
            this.entryid.Font = new System.Drawing.Font("宋体", 13F);
            this.entryid.Location = new System.Drawing.Point(137, 68);
            this.entryid.Name = "entryid";
            this.entryid.Size = new System.Drawing.Size(167, 27);
            this.entryid.TabIndex = 23;
            // 
            // peopleid
            // 
            this.peopleid.Font = new System.Drawing.Font("宋体", 13F);
            this.peopleid.Location = new System.Drawing.Point(137, 111);
            this.peopleid.Name = "peopleid";
            this.peopleid.Size = new System.Drawing.Size(167, 27);
            this.peopleid.TabIndex = 24;
            // 
            // goodsid
            // 
            this.goodsid.Font = new System.Drawing.Font("宋体", 13F);
            this.goodsid.Location = new System.Drawing.Point(137, 156);
            this.goodsid.Name = "goodsid";
            this.goodsid.Size = new System.Drawing.Size(167, 27);
            this.goodsid.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "进仓";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entrytime
            // 
            this.entrytime.Font = new System.Drawing.Font("宋体", 13F);
            this.entrytime.Location = new System.Drawing.Point(137, 199);
            this.entrytime.Name = "entrytime";
            this.entrytime.Size = new System.Drawing.Size(167, 27);
            this.entrytime.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "进仓数量：";
            // 
            // entrynumber
            // 
            this.entrynumber.Font = new System.Drawing.Font("宋体", 13F);
            this.entrynumber.Location = new System.Drawing.Point(137, 240);
            this.entrynumber.Name = "entrynumber";
            this.entrynumber.Size = new System.Drawing.Size(167, 27);
            this.entrynumber.TabIndex = 32;
            this.entrynumber.TextChanged += new System.EventHandler(this.entrynumber_TextChanged);
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("宋体", 13F);
            this.text1.Location = new System.Drawing.Point(137, 290);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(257, 129);
            this.text1.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 456);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.entrynumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.entrytime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goodsid);
            this.Controls.Add(this.peopleid);
            this.Controls.Add(this.entryid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "物料进仓程序";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox entryid;
        private System.Windows.Forms.TextBox peopleid;
        private System.Windows.Forms.TextBox goodsid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker entrytime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entrynumber;
        private System.Windows.Forms.TextBox text1;
    }
}