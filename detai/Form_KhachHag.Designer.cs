namespace detai
{
    partial class Form_KhachHag
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
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3
            // 
            this.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv3.Location = new System.Drawing.Point(0, 139);
            this.dgv3.MultiSelect = false;
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(1204, 330);
            this.dgv3.TabIndex = 0;
            this.dgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellContentClick);
            this.dgv3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv3_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập tên khách hàng:";
            // 
            // tbMa
            // 
            this.tbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMa.Location = new System.Drawing.Point(280, 41);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(194, 34);
            this.tbMa.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::detai.Properties.Resources.save__1_;
            this.button3.Location = new System.Drawing.Point(1008, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 61);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lưu";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Image = global::detai.Properties.Resources.delete__3_;
            this.xoa.Location = new System.Drawing.Point(671, 29);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(129, 61);
            this.xoa.TabIndex = 18;
            this.xoa.Text = "Xóa";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::detai.Properties.Resources.add__1_;
            this.button2.Location = new System.Drawing.Point(843, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 61);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thêm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::detai.Properties.Resources.Search__2_;
            this.button1.Location = new System.Drawing.Point(498, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_KhachHag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1204, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.dgv3);
            this.Name = "Form_KhachHag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.Form_KhachHag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMa;
        public System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Button button3;
    }
}