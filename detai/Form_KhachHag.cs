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
    public partial class Form_KhachHag : Form
    {
        public Form_KhachHag()
        {

            InitializeComponent();
            Loaddulieu();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\phatrienungdungwindow\\detai\\detai\\thucan.mdf;Integrated Security=True");
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtSV = new DataTable();
        void Loaddulieu()
        {
            dtSV.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_khachhang", conn);
            adt.SelectCommand = cmd;
            adt.Fill(dtSV);
            dgv3.DataSource = dtSV;
        }

        void ThemSuaXoaDGV()
        {
            // Thêm nè
            adt.InsertCommand = new SqlCommand("INSERT INTO tbl_khachhang VALUES(@MaKH,@TenKH,@DiaChi,@SoDienThoai,@Gioitinh,@Email,@NgaySinh)", conn);
            SqlParameter t1 = new SqlParameter();
            t1.ParameterName = "@MaKH";
            t1.SourceColumn = "MaKH";
            adt.InsertCommand.Parameters.Add(t1);
            //
            SqlParameter t2 = new SqlParameter();
            t2.ParameterName = "@TenKH";
            t2.SourceColumn = "TenKH";
            adt.InsertCommand.Parameters.Add(t2);

            SqlParameter t3 = new SqlParameter();
            t3.ParameterName = "@DiaChi";
            t3.SourceColumn = "DiaChi";
            adt.InsertCommand.Parameters.Add(t3);

            SqlParameter t4 = new SqlParameter();
            t4.ParameterName = "@SoDienThoai";
            t4.SourceColumn = "SoDienThoai";
            adt.InsertCommand.Parameters.Add(t4);

            SqlParameter t5 = new SqlParameter();
            t5.ParameterName = "@Gioitinh";
            t5.SourceColumn = "Gioitinh";
            adt.InsertCommand.Parameters.Add(t5);

            SqlParameter t6 = new SqlParameter();
            t6.ParameterName = "@Email";
            t6.SourceColumn = "Email";
            adt.InsertCommand.Parameters.Add(t6);

            SqlParameter t7 = new SqlParameter();
            t7.ParameterName = "@NgaySinh";
            t7.SourceColumn = "NgaySinh";
            adt.InsertCommand.Parameters.Add(t7);


            // Sửa nè
            adt.UpdateCommand = new SqlCommand("UPDATE tbl_khachhang SET tenkh = @TenKH, diachi = @DiaChi, sodienthoai = @SoDienThoai, gioitinh = @Gioitinh, Email = @Email,ngaysinh = @NgaySinh WHERE makh = @MaKH", conn);
            SqlParameter u1 = new SqlParameter();
            u1.ParameterName = "@MaKH";
            u1.SourceColumn = "MaKH";
            adt.UpdateCommand.Parameters.Add(u1);
            //
            SqlParameter u2 = new SqlParameter();
            u2.ParameterName = "@TenKH";
            u2.SourceColumn = "TenKH";
            adt.UpdateCommand.Parameters.Add(u2);

            SqlParameter u3 = new SqlParameter();
            u3.ParameterName = "@DiaChi";
            u3.SourceColumn = "DiaChi";
            adt.UpdateCommand.Parameters.Add(u3);
            //
            SqlParameter u4 = new SqlParameter();
            u4.ParameterName = "@SoDienThoai";
            u4.SourceColumn = "SoDienThoai";
            adt.UpdateCommand.Parameters.Add(u4);

            SqlParameter u5 = new SqlParameter();
            u5.ParameterName = "@Gioitinh";
            u5.SourceColumn = "Gioitinh";
            adt.UpdateCommand.Parameters.Add(u5);
            //
            SqlParameter u6 = new SqlParameter();
            u6.ParameterName = "@Email";
            u6.SourceColumn = "Email";
            adt.UpdateCommand.Parameters.Add(u6);
            //
            SqlParameter u7 = new SqlParameter();
            u7.ParameterName = "@NgaySinh";
            u7.SourceColumn = "NgaySinh";
            adt.UpdateCommand.Parameters.Add(u7);

            // Xóa nèk
            adt.DeleteCommand = new SqlCommand("DELETE FROM tbl_khachhang WHERE makh = @MaKH", conn);
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@MaKH";
            p5.SourceColumn = "MaKH";
            adt.DeleteCommand.Parameters.Add(p5);
        }

        private void Form_KhachHag_Load(object sender, EventArgs e)
        {
            conn.Open();
            Loaddulieu();
            ThemSuaXoaDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tukhoa = Convert.ToString(tbMa.Text);
            if (tukhoa != "")
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_khachhang WHERE MaKH = '" + tukhoa + "' OR TenKH LIKE N'%" + tukhoa + "%'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv3.DataSource = dtSV;
            }
            else
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_khachhang", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv3.DataSource = dtSV;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Text = dgv3.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete FROM tbl_khachhang WHERE makh = '" + Text + "'", conn);
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
                MessageBox.Show("Lỗi khóa ngoại.");
            }
            Loaddulieu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKH_Them them = new FormKH_Them();
            them.ShowDialog();
            Loaddulieu();
        }

        private void dgv3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormKH_update khupdate = new FormKH_update();
            khupdate.textBox1.Text = dgv3.CurrentRow.Cells[0].Value.ToString();
            khupdate.textBox2.Text = dgv3.CurrentRow.Cells[1].Value.ToString();
            khupdate.textBox3.Text = dgv3.CurrentRow.Cells[2].Value.ToString();
            khupdate.textBox4.Text = dgv3.CurrentRow.Cells[3].Value.ToString();
            
            if(dgv3.CurrentRow.Cells[4].Value.ToString() == "Nam")
            {
                khupdate.radioButton1.Checked = true;
            }
            else
            {
                khupdate.radioButton2.Checked = true;
            }

            khupdate.textBox5.Text = dgv3.CurrentRow.Cells[5].Value.ToString();
            khupdate.dateTimePicker1.Text = dgv3.CurrentRow.Cells[6].Value.ToString();
            khupdate.ShowDialog();
            Loaddulieu();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                adt.Update((DataTable)dgv3.DataSource);
                Loaddulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
