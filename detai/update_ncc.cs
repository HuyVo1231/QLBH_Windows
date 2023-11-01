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
    public partial class update_ncc : Form
    {
        public update_ncc()
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
                SqlCommand cm = new SqlCommand("UPDATE tbl_ncc set ten_ncc = N'" +ten_ncc +"', sodienthoai = '"+sdt+"', diachi = N'"+diachi+ "' WHERE ma_ncc = '" + ma_ncc+ "'", conn);
                conn.Open();
                if (cm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void update_ncc_Load(object sender, EventArgs e)
        {

        }
    }
}
