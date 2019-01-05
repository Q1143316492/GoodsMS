namespace GoodsMS.UI
{
    partial class FormShowPeoMsg
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
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_showall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_peo
            // 
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(12, 81);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(970, 479);
            this.dgv_peo.TabIndex = 0;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(24, 32);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(161, 18);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "姓名模糊匹配查询:";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_input.Location = new System.Drawing.Point(206, 29);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(471, 27);
            this.txt_input.TabIndex = 2;
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_go.Location = new System.Drawing.Point(707, 26);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(107, 29);
            this.btn_go.TabIndex = 3;
            this.btn_go.Text = "模糊查询";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(841, 26);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(107, 29);
            this.btn_showall.TabIndex = 4;
            this.btn_showall.Text = "显示全部";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // FormShowPeoMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 572);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.dgv_peo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormShowPeoMsg";
            this.Text = "用户信息查询";
            this.Load += new System.EventHandler(this.FormShowMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_peo;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_showall;
    }
}