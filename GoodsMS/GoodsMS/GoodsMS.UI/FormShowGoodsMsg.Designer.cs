namespace GoodsMS.UI
{
    partial class FormShowGoodsMsg
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(851, 21);
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
            this.btn_go.Location = new System.Drawing.Point(717, 21);
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
            this.txt_input.Location = new System.Drawing.Point(216, 24);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(471, 27);
            this.txt_input.TabIndex = 6;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(34, 27);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(179, 18);
            this.lab_name.TabIndex = 5;
            this.lab_name.Text = "货物名模糊匹配查询:";
            // 
            // dgv_peo
            // 
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(12, 72);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(983, 444);
            this.dgv_peo.TabIndex = 9;
            // 
            // FormShowGoodsMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 528);
            this.Controls.Add(this.dgv_peo);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormShowGoodsMsg";
            this.Text = "货物信息查询";
            this.Load += new System.EventHandler(this.FormShowGoodsMsg_Load);
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
    }
}