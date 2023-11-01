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
    public partial class FormKH_update : Form
    {
        public FormKH_update()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaysinh = dateTimePicker1.Value.ToString();
                string makh = textBox1.Text;
                string tenkh = textBox2.Text;
                string diachi = textBox3.Text;
                string sdt = textBox4.Text;
                string email = textBox5.Text;
                string gioitinh;
                if (radioButton1.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                SqlCommand cm = new SqlCommand("UPDATE tbl_khachhang SET makh = '" +makh+ "',tenkh = N'" + tenkh+"', diachi = N'" +diachi+ "', sodienthoai = '" +sdt + "', gioitinh = N'" + gioitinh +"', email = '" +email+ "',ngaysinh = '" +ngaysinh + "' WHERE makh = '" +makh + "'", conn);
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
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void FormKH_update_Load(object sender, EventArgs e)
        {

        }
    }
}
