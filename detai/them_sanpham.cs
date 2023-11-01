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
    public partial class them_sanpham : Form
    {
        public them_sanpham()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();

        void ncc()
        {
            SqlCommand cmd2 = new SqlCommand("SELECT ma_ncc FROM tbl_ncc", conn);
            adt.SelectCommand = cmd2;
            adt.Fill(dtSV);
            tb3.DataSource = dtSV;
            tb3.DisplayMember = "ma_ncc";
            tb3.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string masanpham = textBox1.Text;
                string tensanpham = textBox2.Text;
                string nhacungcap = tb3.Text;
                string soluongnhap = textBox4.Text;
                string dongianhap = textBox5.Text;
                int dongiaban = Convert.ToInt32(textBox6.Text);
                int soluongdaban = Convert.ToInt32(textBox7.Text);
                int tongtien = dongiaban * soluongdaban;
                string ngaynhap = dateTimePicker1.Value.ToShortDateString();
                string ngayhethan = dateTimePicker2.Value.ToShortDateString();

                SqlCommand cm = new SqlCommand("INSERT INTO tbl_sanpham VALUES ('" + masanpham + "',N'" + tensanpham + "','" + nhacungcap + "','" + soluongnhap + "','" + soluongdaban + "','" + dongianhap + "','" + dongiaban + "','" + ngaynhap + "','" + ngayhethan + "','" + soluongdaban * dongiaban + "') ", conn);
                conn.Open();
                if ((cm.ExecuteNonQuery() == 1))
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void them_sanpham_Load(object sender, EventArgs e)
        {
            tb3.Items.Clear();
            ncc();

        }

        private void tb3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
