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
    public partial class FormNV_Them : Form
    {
        public FormNV_Them()
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
                string ngaysinh = dateTimePicker1.Value.ToString();
                string ngayvaolam = dateTimePicker2.Value.ToString();

                SqlCommand cm = new SqlCommand("INSERT INTO tbl_nhanvien VALUES ('"+manv+"',N'"+tennv+"',N'"+gioitinh+"',N'"+diachi+"','"+sdt+"','"+ngaysinh+"','"+ngayvaolam+"')", conn);
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
                MessageBox.Show("Lỗi điền dữ liệu");
            }
        }

        private void FormNV_Them_Load(object sender, EventArgs e)
        {

        }
    }
}
