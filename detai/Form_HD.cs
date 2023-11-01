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
    public partial class Form_HD : Form
    {
        public Form_HD()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();
        DataTable dtSV2 = new DataTable();
        DataTable dtSV3 = new DataTable();
        DataTable dtSV4 = new DataTable();
        DataTable dtSV5 = new DataTable();

        void KH ()
        {
            SqlCommand cmd2 = new SqlCommand("SELECT makh FROM tbl_khachhang", conn);
            adt.SelectCommand = cmd2;
            adt.Fill(dtSV);
            cb2.DataSource = dtSV;
            cb2.DisplayMember = "makh";
            cb2.Text = "";
        }
        
        void nv()
        {
            SqlCommand cmd = new SqlCommand("SELECT manv FROM tbl_nhanvien", conn);
            adt.SelectCommand = cmd;
            adt.Fill(dtSV2);
            cb1.DataSource = dtSV2;
            cb1.DisplayMember = "manv";
            cb1.Text = "";
        }

        void sp()
        {
            SqlCommand cmd3 = new SqlCommand("SELECT masanpham FROM tbl_sanpham", conn);
            adt.SelectCommand = cmd3;
            adt.Fill(dtSV3);
            cb3.DataSource = dtSV3;
            cb3.DisplayMember = "masanpham";
            cb3.Text = "";
        }

        void hd()
        {
            dtSV4.Clear();
            SqlCommand cmd4 = new SqlCommand("SELECT mahdban FROM tbl_HDban", conn);
            adt.SelectCommand = cmd4;
            adt.Fill(dtSV4);
            cb4.DataSource = dtSV4;
            cb4.DisplayMember = "mahdban";
            cb4.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void Form_HD_Load(object sender, EventArgs e)
        {
            conn.Open();
            KH();
            nv();
            sp();
            hd();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string masanpham = cb3.Text;
            SqlCommand cm = new SqlCommand("SELECT tensanpham, dongiaban FROM tbl_sanpham WHERE masanpham = '" +masanpham+ "'", conn);
            SqlDataReader dr = cm.ExecuteReader();
            
            while(dr.Read())
            {
                textBox3.Text = dr.GetValue(0).ToString();
                textBox4.Text = dr.GetValue(1).ToString();
            }
            
            
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = cb4.Text;
                string thanhtien;
                int Tongtien = 0;
                SqlCommand cm = new SqlCommand("SELECT a.mahdban,a.makh,a.manv,a.ngayban,b.thanhtien FROM tbl_HDban as a,tbl_chitiethdban as b WHERE a.mahdban = '" +mahd+ "' AND a.mahdban = b.mahdban",conn);
                SqlDataReader dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    textBox1.Text = dr.GetValue(0).ToString();
                    cb2.Text = dr.GetValue(1).ToString();
                    cb1.Text = dr.GetValue(2).ToString();
                    dateTimePicker1.Text = dr.GetValue(3).ToString();
                    thanhtien = dr.GetValue(4).ToString();
                    Tongtien += Convert.ToInt32(thanhtien);
                }
                dr.Close();
                SqlCommand cmd2 = new SqlCommand("UPDATE tbl_hdban set tongtien = " +Tongtien + " WHERE mahdban = '"+mahd+ "'", conn);
                cmd2.ExecuteNonQuery();
                textBox2.Text = Tongtien.ToString();
                
                dtSV5.Clear();
                SqlCommand cmd = new SqlCommand("SELECT MaHDBan,a.masanpham,TenSanPham,a.Soluong,dongia,thanhtien FROM tbl_chitiethdban as a, tbl_sanpham as b WHERE a.masanpham = b.masanpham AND a.mahdban = '" +mahd+ "'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV5);
                dgvHD.DataSource = dtSV5;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //
                textBox2.Clear();
                string mahd = textBox1.Text;
                string ngayban = dateTimePicker1.Value.ToString();
                string makh = cb2.Text;
                string manv = cb1.Text;
                int tongtien = Convert.ToInt32(textBox6.Text);
                //
                string masp = cb3.Text;
                string tensp = textBox3.Text;
                int dongia = Convert.ToInt32(textBox4.Text);
                int soluong = Convert.ToInt32(textBox7.Text);
                int thanhtien = dongia * soluong;

                SqlCommand cmd5 = new SqlCommand("SELECT soluongnhap,soluongdaban FROM tbl_sanpham WHERE masanpham = '" + masp + "'", conn);
                SqlDataReader dr = cmd5.ExecuteReader();
                int soluongnhap = 0;
                int soluongdaban = 0;
                int soluongconlai = 0;
                while (dr.Read())
                {
                    soluongnhap = int.Parse(dr.GetValue(0).ToString());
                    soluongdaban = int.Parse(dr.GetValue(1).ToString());
                    soluongconlai = soluongnhap - soluongdaban;
                }
                dr.Close();
                if (soluongconlai < soluong)
                {
                    MessageBox.Show("Số lượng còn lại không đủ");
                    return;
                }
                //
                try
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO tbl_HDBan(MaHDBan,MaNV,NgayBan,MaKH,TongTien) VALUES('" + mahd + "','" + manv + "','" + ngayban + "','" + makh + "','" + tongtien + "')", conn);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tbl_chitiethdban(MaHDBan,masanpham,soluong,dongia,thanhtien) VALUES('" + mahd + "','" + masp + "','" + soluong + "','" + dongia + "','" + thanhtien + "')", conn);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch(Exception ex)
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tbl_chitiethdban(MaHDBan,masanpham,soluong,dongia,thanhtien) VALUES('" + mahd + "','" + masp + "','" + soluong + "','" + dongia + "','" + thanhtien + "')", conn);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }

                dtSV5.Clear();
                SqlCommand cmd = new SqlCommand("SELECT MaHDBan,a.masanpham ,TenSanPham,a.Soluong,dongia,thanhtien FROM tbl_chitiethdban as a, tbl_sanpham as b WHERE a.masanpham = b.masanpham AND a.mahdban = '" + mahd + "'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV5);
                dgvHD.DataSource = dtSV5;
                hd();
                // UPDATE
                SqlCommand cmd4 = new SqlCommand("UPDATE tbl_sanpham SET soluongdaban = soluongdaban + " + soluong + ", tongtien = (soluongdaban +"+soluong +")"+ "* dongiaban WHERE masanpham = '" + masp + "'", conn);
                cmd4.ExecuteNonQuery();

                cb3.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";

                try
                {

                    string mahd1 = textBox1.Text;
                    string thanhtien1;
                    int Tongtien = 0;
                    SqlCommand cm5 = new SqlCommand("SELECT thanhtien FROM tbl_chitiethdban WHERE mahdban = '" +mahd1+ "'", conn);
                    SqlDataReader dr2 = cm5.ExecuteReader();
                    while (dr2.Read())
                    {
                        thanhtien1 = dr2.GetValue(0).ToString();
                        Tongtien += Convert.ToInt32(thanhtien1);

                    }
                    dr2.Close();
                    textBox2.Text = Tongtien.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string dongia = textBox4.Text;
            string soluong = textBox7.Text;
            int thanhtien;
            try
            {
                thanhtien = int.Parse(dongia) * int.Parse(soluong);
            }
            catch(Exception ex)
            {
                thanhtien = 0;
            }
            textBox6.Text = thanhtien.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa
            try
            {
                string mahd = cb4.Text;
                SqlCommand cmd3 = new SqlCommand("DELETE FROM tbl_chitiethdban WHERE mahdban = '" + mahd + "'", conn);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM tbl_HDBan WHERE mahdban = '" +mahd+ "'", conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                hd();
                dgvHD.DataSource = "";
                textBox1.Text = "";
                cb1.Text = "";
                cb2.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đang coi lỗi gì nèk");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
