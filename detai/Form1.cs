using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace detai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();

        void Loaddulieu()
        {
            dtSV.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_sanpham", conn);
            adt.SelectCommand = cmd;
            adt.Fill(dtSV);
            dgv1.DataSource = dtSV;
        }

        void ThemSuaXoaDGV()
        {
            // Thêm nè
            adt.InsertCommand = new SqlCommand("INSERT INTO tbl_sanpham VALUES(@masanpham,@tensanpham,@ma_ncc,@soluongnhap,@soluongdaban,@dongianhap,@dongiaban,@ngaynhap,@ngayhethan,@tongtien)", conn);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@masanpham";
            p1.SourceColumn = "masanpham";
            adt.InsertCommand.Parameters.Add(p1);
            //
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@tensanpham";
            p2.SourceColumn = "tensanpham";
            adt.InsertCommand.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@ma_ncc";
            p3.SourceColumn = "ma_ncc";
            adt.InsertCommand.Parameters.Add(p3);
            //
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@soluongnhap";
            p4.SourceColumn = "soluongnhap";
            adt.InsertCommand.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@soluongdaban";
            p5.SourceColumn = "soluongdaban";
            adt.InsertCommand.Parameters.Add(p5);
            //
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@dongianhap";
            p6.SourceColumn = "dongianhap";
            adt.InsertCommand.Parameters.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@dongiaban";
            p7.SourceColumn = "dongiaban";
            adt.InsertCommand.Parameters.Add(p7);
            //
            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@ngaynhap";
            p8.SourceColumn = "ngaynhap";
            adt.InsertCommand.Parameters.Add(p8);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@ngayhethan";
            p9.SourceColumn = "ngayhethan";
            adt.InsertCommand.Parameters.Add(p9);
            //
            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@tongtien";
            p10.SourceColumn = "tongtien";
            adt.InsertCommand.Parameters.Add(p10);


            // Sửa nè
            adt.UpdateCommand = new SqlCommand("UPDATE tbl_sanpham SET tensanpham = @tensanpham,ma_ncc = @ma_ncc, soluongnhap = @soluongnhap,soluongdaban = @soluongdaban,dongianhap =@dongianhap,dongiaban = @dongiaban,ngaynhap =@ngaynhap, ngayhethan = @ngayhethan,tongtien = @tongtien WHERE masanpham = @masanpham", conn);
            SqlParameter u1 = new SqlParameter();
            u1.ParameterName = "@masanpham";
            u1.SourceColumn = "masanpham";
            adt.UpdateCommand.Parameters.Add(u1);
            //
            SqlParameter u2 = new SqlParameter();
            u2.ParameterName = "@tensanpham";
            u2.SourceColumn = "tensanpham";
            adt.UpdateCommand.Parameters.Add(u2);

            SqlParameter u3 = new SqlParameter();
            u3.ParameterName = "@ma_ncc";
            u3.SourceColumn = "ma_ncc";
            adt.UpdateCommand.Parameters.Add(u3);
            //
            SqlParameter u4 = new SqlParameter();
            u4.ParameterName = "@soluongnhap";
            u4.SourceColumn = "soluongnhap";
            adt.UpdateCommand.Parameters.Add(u4);

            SqlParameter u5 = new SqlParameter();
            u5.ParameterName = "@soluongdaban";
            u5.SourceColumn = "soluongdaban";
            adt.UpdateCommand.Parameters.Add(u5);
            //
            SqlParameter u6 = new SqlParameter();
            u6.ParameterName = "@dongianhap";
            u6.SourceColumn = "dongianhap";
            adt.UpdateCommand.Parameters.Add(u6);

            SqlParameter u7 = new SqlParameter();
            u7.ParameterName = "@dongiaban";
            u7.SourceColumn = "dongiaban";
            adt.UpdateCommand.Parameters.Add(u7);
            //
            SqlParameter u8 = new SqlParameter();
            u8.ParameterName = "@ngaynhap";
            u8.SourceColumn = "ngaynhap";
            adt.UpdateCommand.Parameters.Add(u8);

            SqlParameter u9 = new SqlParameter();
            u9.ParameterName = "@ngayhethan";
            u9.SourceColumn = "ngayhethan";
            adt.UpdateCommand.Parameters.Add(u9);
            //
            SqlParameter u10 = new SqlParameter();
            u10.ParameterName = "@tongtien";
            u10.SourceColumn = "tongtien";
            adt.UpdateCommand.Parameters.Add(u10);

            // Xóa nèk
            adt.DeleteCommand = new SqlCommand("DELETE FROM tbl_sanpham WHERE masanpham = @masanpham", conn);
            SqlParameter x1 = new SqlParameter();
            x1.ParameterName = "@masanpham";
            x1.SourceColumn = "masanpham";
            adt.DeleteCommand.Parameters.Add(x1);
        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            Loaddulieu();
            ThemSuaXoaDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tukhoa = Convert.ToString(tb1.Text) ;
            if (tukhoa != "")
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_sanpham WHERE masanpham = '" + tukhoa + "' OR tensanpham LIKE N'%" + tukhoa + "%'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv1.DataSource = dtSV;
            }
            else
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_sanpham", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv1.DataSource = dtSV;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            them_sanpham them = new them_sanpham();
            them.ShowDialog();
            Loaddulieu();

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update_sanphamform update = new update_sanphamform();
            update.box1.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            update.cb1.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            update.textBox4.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            update.textBox1.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            update.textBox5.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            update.textBox6.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            update.dateTimePicker1.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
            update.dateTimePicker2.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
            update.ShowDialog();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete FROM tbl_sanpham WHERE masanpham = '" + Text + "'", conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu");
            }
            Loaddulieu();
        } 

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adt.Update((DataTable)dgv1.DataSource);
                Loaddulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
