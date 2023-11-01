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
    public partial class Form_Dangky : Form
    {
        public Form_Dangky()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        private void Form_Dangky_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string taikhoan = textBox1.Text;
                string matkhau = textBox2.Text;
                string email = textBox3.Text;
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_dangnhap VALUES('"+taikhoan+"','"+matkhau+"','"+email+"')", conn);
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Hide();
                    FormMain main = new FormMain();
                    main.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Đã tồn tại username");
                conn.Close();
            }
        }
    }
}
