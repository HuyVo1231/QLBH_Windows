using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detai
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string taikhoan = textBox1.Text;
                string matkhau = textBox2.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_dangnhap WHERE taikhoan = '" +taikhoan+ "' AND matkhau = '" +matkhau+ "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) { 
                    this.Hide();
                    FormMain main = new FormMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string taikhoan = textBox1.Text;
                string matkhau = textBox2.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_dangnhap WHERE taikhoan = '" + taikhoan + "' AND matkhau = '" + matkhau + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    this.Hide();
                    FormMain main = new FormMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Dangky dangky = new Form_Dangky();
            this.Hide();
            dangky.ShowDialog();

        }
    }
}
