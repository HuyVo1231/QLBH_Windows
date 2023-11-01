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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace detai
{
    public partial class them_ncc : Form
    {
        public them_ncc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_ncc = textBox1.Text;
                string ten_ncc = textBox2.Text;
                string sdt = textBox4.Text;
                string diachi = textBox3.Text;
                SqlCommand cm = new SqlCommand("INSERT INTO tbl_ncc VALUES ('" + ma_ncc + "',N'" + ten_ncc + "','"+sdt+"',N'"+diachi+"')", conn);
                conn.Open();
                if (cm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi điền dữ liệu");
            }

        }
    }
}
