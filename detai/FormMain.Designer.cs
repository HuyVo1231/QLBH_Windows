namespace detai
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sp = new System.Windows.Forms.ToolStripMenuItem();
            this.ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.kh = new System.Windows.Forms.ToolStripMenuItem();
            this.nv = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d9anToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sp,
            this.ncc,
            this.kh,
            this.nv,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.d9anToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sp
            // 
            this.sp.Image = global::detai.Properties.Resources.iconsp;
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(161, 24);
            this.sp.Text = "Quản lý sản phẩm";
            this.sp.Click += new System.EventHandler(this.sp_Click);
            // 
            // ncc
            // 
            this.ncc.Image = global::detai.Properties.Resources.ncc;
            this.ncc.Name = "ncc";
            this.ncc.Size = new System.Drawing.Size(185, 24);
            this.ncc.Text = "Quản lý nhà cung cấp";
            this.ncc.Click += new System.EventHandler(this.ncc_Click);
            // 
            // kh
            // 
            this.kh.Image = global::detai.Properties.Resources.kh;
            this.kh.Name = "kh";
            this.kh.Size = new System.Drawing.Size(172, 24);
            this.kh.Text = "Quản lý khách hàng";
            this.kh.Click += new System.EventHandler(this.kh_Click);
            // 
            // nv
            // 
            this.nv.Image = global::detai.Properties.Resources.nv;
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(160, 24);
            this.nv.Text = "Quản lý nhân viên";
            this.nv.Click += new System.EventHandler(this.nv_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Image = global::detai.Properties.Resources.pngtree_invoice_icon_design_vector_png_image_1586820;
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // d9anToolStripMenuItem
            // 
            this.d9anToolStripMenuItem.Image = global::detai.Properties.Resources._out;
            this.d9anToolStripMenuItem.Name = "d9anToolStripMenuItem";
            this.d9anToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.d9anToolStripMenuItem.Text = "Đăng xuất";
            this.d9anToolStripMenuItem.Click += new System.EventHandler(this.d9anToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::detai.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1338, 782);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ BÁN THỨC ĂN CHĂN NUÔI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sp;
        private System.Windows.Forms.ToolStripMenuItem ncc;
        private System.Windows.Forms.ToolStripMenuItem kh;
        private System.Windows.Forms.ToolStripMenuItem nv;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d9anToolStripMenuItem;
    }
}