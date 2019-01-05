namespace GoodsMS.UI
{
    partial class FormUpdateGoodsMsg
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
            this.txt_other = new System.Windows.Forms.TextBox();
            this.lab_other = new System.Windows.Forms.Label();
            this.txt_GoodsNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GoodsUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_goodsSize = new System.Windows.Forms.TextBox();
            this.lab_goodsSize = new System.Windows.Forms.Label();
            this.txt_goodsname = new System.Windows.Forms.TextBox();
            this.lab_usname = new System.Windows.Forms.Label();
            this.txt_goodsid = new System.Windows.Forms.TextBox();
            this.lab_usid = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_peo
            // 
            this.dgv_peo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_peo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peo.Location = new System.Drawing.Point(12, 71);
            this.dgv_peo.Name = "dgv_peo";
            this.dgv_peo.RowTemplate.Height = 23;
            this.dgv_peo.Size = new System.Drawing.Size(997, 113);
            this.dgv_peo.TabIndex = 14;
            this.dgv_peo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_peo_CellClick);
            this.dgv_peo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_peo_CellMouseDoubleClick);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_showall.Location = new System.Drawing.Point(851, 20);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(107, 29);
            this.btn_showall.TabIndex = 13;
            this.btn_showall.Text = "显示全部";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_go.Location = new System.Drawing.Point(717, 20);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(107, 29);
            this.btn_go.TabIndex = 12;
            this.btn_go.Text = "模糊查询";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_input.Location = new System.Drawing.Point(216, 23);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(471, 27);
            this.txt_input.TabIndex = 11;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_name.Location = new System.Drawing.Point(34, 26);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(179, 18);
            this.lab_name.TabIndex = 10;
            this.lab_name.Text = "货物名模糊匹配查询:";
            // 
            // txt_other
            // 
            this.txt_other.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_other.Location = new System.Drawing.Point(408, 339);
            this.txt_other.Multiline = true;
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(448, 68);
            this.txt_other.TabIndex = 47;
            // 
            // lab_other
            // 
            this.lab_other.AutoSize = true;
            this.lab_other.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_other.Location = new System.Drawing.Point(313, 339);
            this.lab_other.Name = "lab_other";
            this.lab_other.Size = new System.Drawing.Size(53, 18);
            this.lab_other.TabIndex = 46;
            this.lab_other.Text = "备注:";
            // 
            // txt_GoodsNum
            // 
            this.txt_GoodsNum.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_GoodsNum.Location = new System.Drawing.Point(118, 330);
            this.txt_GoodsNum.Name = "txt_GoodsNum";
            this.txt_GoodsNum.Size = new System.Drawing.Size(167, 27);
            this.txt_GoodsNum.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(23, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "货物数量:";
            // 
            // txt_GoodsUnit
            // 
            this.txt_GoodsUnit.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_GoodsUnit.Location = new System.Drawing.Point(689, 272);
            this.txt_GoodsUnit.Name = "txt_GoodsUnit";
            this.txt_GoodsUnit.Size = new System.Drawing.Size(167, 27);
            this.txt_GoodsUnit.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(594, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "计量单位:";
            // 
            // txt_goodsSize
            // 
            this.txt_goodsSize.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_goodsSize.Location = new System.Drawing.Point(408, 269);
            this.txt_goodsSize.Name = "txt_goodsSize";
            this.txt_goodsSize.Size = new System.Drawing.Size(167, 27);
            this.txt_goodsSize.TabIndex = 41;
            // 
            // lab_goodsSize
            // 
            this.lab_goodsSize.AutoSize = true;
            this.lab_goodsSize.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_goodsSize.Location = new System.Drawing.Point(313, 272);
            this.lab_goodsSize.Name = "lab_goodsSize";
            this.lab_goodsSize.Size = new System.Drawing.Size(89, 18);
            this.lab_goodsSize.TabIndex = 40;
            this.lab_goodsSize.Text = "规格型号:";
            // 
            // txt_goodsname
            // 
            this.txt_goodsname.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_goodsname.Location = new System.Drawing.Point(118, 269);
            this.txt_goodsname.Name = "txt_goodsname";
            this.txt_goodsname.Size = new System.Drawing.Size(167, 27);
            this.txt_goodsname.TabIndex = 39;
            // 
            // lab_usname
            // 
            this.lab_usname.AutoSize = true;
            this.lab_usname.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usname.Location = new System.Drawing.Point(23, 272);
            this.lab_usname.Name = "lab_usname";
            this.lab_usname.Size = new System.Drawing.Size(89, 18);
            this.lab_usname.TabIndex = 38;
            this.lab_usname.Text = "货物名称:";
            // 
            // txt_goodsid
            // 
            this.txt_goodsid.Font = new System.Drawing.Font("宋体", 13F);
            this.txt_goodsid.Location = new System.Drawing.Point(118, 209);
            this.txt_goodsid.Name = "txt_goodsid";
            this.txt_goodsid.Size = new System.Drawing.Size(167, 27);
            this.txt_goodsid.TabIndex = 37;
            // 
            // lab_usid
            // 
            this.lab_usid.AutoSize = true;
            this.lab_usid.Font = new System.Drawing.Font("宋体", 13F);
            this.lab_usid.Location = new System.Drawing.Point(23, 212);
            this.lab_usid.Name = "lab_usid";
            this.lab_usid.Size = new System.Drawing.Size(89, 18);
            this.lab_usid.TabIndex = 36;
            this.lab_usid.Text = "货物代码:";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_update.Location = new System.Drawing.Point(600, 206);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 29);
            this.btn_update.TabIndex = 52;
            this.btn_update.Text = "提交修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_select.Location = new System.Drawing.Point(320, 206);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(107, 29);
            this.btn_select.TabIndex = 51;
            this.btn_select.Text = "选择货物";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_del.Location = new System.Drawing.Point(458, 206);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(107, 29);
            this.btn_del.TabIndex = 50;
            this.btn_del.Text = "删除该货物";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // FormUpdateGoodsMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 444);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_other);
            this.Controls.Add(this.lab_other);
            this.Controls.Add(this.txt_GoodsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_GoodsUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_goodsSize);
            this.Controls.Add(this.lab_goodsSize);
            this.Controls.Add(this.txt_goodsname);
            this.Controls.Add(this.lab_usname);
            this.Controls.Add(this.txt_goodsid);
            this.Controls.Add(this.lab_usid);
            this.Controls.Add(this.dgv_peo);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lab_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormUpdateGoodsMsg";
            this.Text = "更新货物信息";
            this.Load += new System.EventHandler(this.FormUpdateGoodsMsg_Load);
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
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.Label lab_other;
        private System.Windows.Forms.TextBox txt_GoodsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_GoodsUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_goodsSize;
        private System.Windows.Forms.Label lab_goodsSize;
        private System.Windows.Forms.TextBox txt_goodsname;
        private System.Windows.Forms.Label lab_usname;
        private System.Windows.Forms.TextBox txt_goodsid;
        private System.Windows.Forms.Label lab_usid;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_del;
    }
}