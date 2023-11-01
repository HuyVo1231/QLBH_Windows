using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detai
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void sp_Click(object sender, EventArgs e)
        {
             if(!CheckExitsForm("Form1"))
            {
                Form1 form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }
             else
            {
                ActiveChildForm("Form1");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            } return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void ncc_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("Form_NhaCungCap"))
            {
                Form_NhaCungCap ncc = new Form_NhaCungCap();
                ncc.MdiParent = this;
                ncc.Show();
            }
            else
            {
                ActiveChildForm("Form_NhaCungCap");
            }
        }

        private void kh_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("Form_KhachHag"))
            {
                Form_KhachHag kh = new Form_KhachHag();
                kh.MdiParent = this;
                kh.Show();
            }
            else
            {
                ActiveChildForm("Form_KhachHag");
            }
        }

        private void nv_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("Form_NhanVien"))
            {
                Form_NhanVien kh = new Form_NhanVien();
                kh.MdiParent = this;
                kh.Show();
            }
            else
            {
                ActiveChildForm("Form_NhanVien");
            }
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("Form_HD"))
            {
                Form_HD kh = new Form_HD();
                kh.MdiParent = this;
                kh.Show();
            }
            else
            {
                ActiveChildForm("Form_HD");
            }
        }

        private void d9anToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap dn = new Form_DangNhap();
            dn.ShowDialog();
        }
    }
}
