namespace detai
{
    partial class Form_NhaCungCap
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(-2, 155);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(1118, 323);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellDoubleClick);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Image = global::detai.Properties.Resources.delete__3_;
            this.xoa.Location = new System.Drawing.Point(812, 38);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(120, 66);
            this.xoa.TabIndex = 13;
            this.xoa.Text = "Xóa";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập mã hoặc tên ncc:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::detai.Properties.Resources.add__1_;
            this.button2.Location = new System.Drawing.Point(656, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 66);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::detai.Properties.Resources.Search__2_;
            this.button1.Location = new System.Drawing.Point(503, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(264, 54);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(217, 34);
            this.tb1.TabIndex = 9;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(200, 237);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 29);
            this.lb1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::detai.Properties.Resources.save__1_;
            this.button3.Location = new System.Drawing.Point(959, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "Lưu";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1117, 474);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgv2);
            this.Name = "Form_NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhà cung cấp";
            this.Load += new System.EventHandler(this.Form_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button3;
    }
}