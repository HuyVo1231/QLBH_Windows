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
    public partial class update_sanphamform : Form
    {
        public update_sanphamform()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();
        void ncc()
        {
            dtSV.Clear();
            SqlCommand cmd4 = new SqlCommand("SELECT ma_ncc FROM tbl_ncc", conn);
            adt.SelectCommand = cmd4;
            adt.Fill(dtSV);
            cb1.DataSource = dtSV;
            cb1.DisplayMember = "ma_ncc";
            cb1.Text = "";
        }


        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string masanpham = box1.Text;
                string tensanpham = textBox2.Text;
                string nhacungcap = cb1.Text;
                string soluongnhap = textBox4.Text;
                string dongianhap = textBox5.Text;
                int dongiaban = Convert.ToInt32(textBox6.Text);
                int soluongdaban = Convert.ToInt32(textBox1.Text);
                int tongtien = dongiaban * soluongdaban;
                string ngaynhap = dateTimePicker1.Value.ToShortDateString();
                string ngayhethan = dateTimePicker2.Value.ToShortDateString();
                SqlCommand cm = new SqlCommand("UPDATE tbl_sanpham SET masanpham = '" + masanpham + "', tensanpham = N'" + tensanpham + "', ma_ncc = '" + nhacungcap + "', soluongnhap = '" + soluongnhap + "', soluongdaban = '" + soluongdaban + "', dongianhap = '" + dongianhap + "',dongiaban = '" + dongiaban + "', ngaynhap = '" + ngaynhap + "', ngayhethan = '" + ngayhethan + "',tongtien = '" + tongtien + "' WHERE masanpham = '" + masanpham + "'", conn);
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

        private void update_sanphamform_Load(object sender, EventArgs e)
        {
            ncc();
        }
    }
}
