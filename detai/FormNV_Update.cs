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
    public partial class FormNV_Update : Form
    {
        public FormNV_Update()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = textBox1.Text;
                string tennv = textBox2.Text;
                string gioitinh;
                if (radioButton1.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                string diachi = textBox3.Text;
                string sdt = textBox4.Text;
                string ngaysinh = dateTimePicker1.Value.ToShortDateString();
                string ngayvaolam = dateTimePicker2.Value.ToShortDateString();
                SqlCommand cm = new SqlCommand("UPDATE tbl_nhanvien SET tennv = N'"+ tennv+"', gioitinh = N'" +gioitinh+ "', diachi = N'" +diachi+ "', sodienthoai = '" +sdt+ "', ngaysinh = '" +ngaysinh+ "', ngayvaolam = '" +ngayvaolam+ "' WHERE manv = '" +manv+ "'", conn);
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

        private void FormNV_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
