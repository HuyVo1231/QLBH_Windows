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
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {

            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();

        void Loaddulieu()
        {
            dtSV.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_nhanvien", conn);
            adt.SelectCommand = cmd;
            adt.Fill(dtSV);
            dgv4.DataSource = dtSV;
        }

        void ThemSuaXoaDGV()
        {
            // Thêm nè
            adt.InsertCommand = new SqlCommand("INSERT INTO tbl_nhanvien VALUES(@MaNV,@TenNV,@Gioitinh,@DiaChi,@sodienthoai,@NgaySinh,@NgayVaoLam)", conn);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@MaNV";
            p1.SourceColumn = "MaNV";
            adt.InsertCommand.Parameters.Add(p1);
            //
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@TenNV";
            p2.SourceColumn = "TenNV";
            adt.InsertCommand.Parameters.Add(p2);


            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Gioitinh";
            p3.SourceColumn = "Gioitinh";
            adt.InsertCommand.Parameters.Add(p3);
            //
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@DiaChi";
            p4.SourceColumn = "DiaChi";
            adt.InsertCommand.Parameters.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@sodienthoai";
            p5.SourceColumn = "sodienthoai";
            adt.InsertCommand.Parameters.Add(p5);
            //
            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@NgaySinh";
            p6.SourceColumn = "NgaySinh";
            adt.InsertCommand.Parameters.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@NgayVaoLam";
            p7.SourceColumn = "NgayVaoLam";
            adt.InsertCommand.Parameters.Add(p7);
            
            // Sửa nè
            adt.UpdateCommand = new SqlCommand("UPDATE tbl_nhanvien SET TenNV = @TenNV,Gioitinh = @Gioitinh,DiaChi = @DiaChi, sodienthoai = @sodienthoai,ngaysinh = @NgaySinh, ngayvaolam = @NgayVaoLam WHERE MaNV = @MaNV", conn);
            SqlParameter u1 = new SqlParameter();
            u1.ParameterName = "@MaNV";
            u1.SourceColumn = "MaNV";
            adt.UpdateCommand.Parameters.Add(u1);
            //
            SqlParameter u2 = new SqlParameter();
            u2.ParameterName = "@TenNV";
            u2.SourceColumn = "TenNV";
            adt.UpdateCommand.Parameters.Add(u2);

            SqlParameter u3 = new SqlParameter();
            u3.ParameterName = "@Gioitinh";
            u3.SourceColumn = "Gioitinh";
            adt.UpdateCommand.Parameters.Add(u3);
            //
            SqlParameter u4 = new SqlParameter();
            u4.ParameterName = "@DiaChi";
            u4.SourceColumn = "DiaChi";
            adt.UpdateCommand.Parameters.Add(u4);


            SqlParameter u5 = new SqlParameter();
            u5.ParameterName = "@sodienthoai";
            u5.SourceColumn = "sodienthoai";
            adt.UpdateCommand.Parameters.Add(u5);
            //
            SqlParameter u6 = new SqlParameter();
            u6.ParameterName = "@NgaySinh";
            u6.SourceColumn = "NgaySinh";
            adt.UpdateCommand.Parameters.Add(u6);

            SqlParameter u7 = new SqlParameter();
            u7.ParameterName = "@NgayVaoLam";
            u7.SourceColumn = "NgayVaoLam";
            adt.UpdateCommand.Parameters.Add(u7);


            // Xóa nèk
            adt.DeleteCommand = new SqlCommand("DELETE FROM tbl_nhanvien WHERE MaNV = @MaNV", conn);
            SqlParameter x8 = new SqlParameter();
            x8.ParameterName = "@MaNV";
            x8.SourceColumn = "MaNV";
            adt.DeleteCommand.Parameters.Add(x8);
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            Loaddulieu();
            ThemSuaXoaDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tukhoa = Convert.ToString(tb1.Text);
            if (tukhoa != "")
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_nhanvien WHERE MaNV = '" + tukhoa + "' OR TenNV LIKE N'%" + tukhoa + "%'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv4.DataSource = dtSV;
            }
            else
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_nhanvien", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv4.DataSource = dtSV;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Text = dgv4.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete FROM tbl_nhanvien WHERE MaNV = '" + Text + "'", conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu");
            }
            Loaddulieu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNV_Them NVthm = new FormNV_Them();
            NVthm.ShowDialog();
            Loaddulieu();
        }

        private void dgv4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FormNV_Update update = new FormNV_Update();
            update.textBox1.Text = dgv4.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dgv4.CurrentRow.Cells[1].Value.ToString();
            if (dgv4.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                update.radioButton1.Checked = true;
            }
            else
            {
                update.radioButton2.Checked = true;
            }
            update.textBox3.Text = dgv4.CurrentRow.Cells[3].Value.ToString();
            update.textBox4.Text = dgv4.CurrentRow.Cells[4].Value.ToString();
            update.dateTimePicker1.Text = dgv4.CurrentRow.Cells[5].Value.ToString();
            update.dateTimePicker2.Text = dgv4.CurrentRow.Cells[6].Value.ToString();
            update.ShowDialog();
            Loaddulieu();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adt.Update((DataTable)dgv4.DataSource);
                Loaddulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
