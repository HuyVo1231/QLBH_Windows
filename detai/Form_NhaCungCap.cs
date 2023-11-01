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
    public partial class Form_NhaCungCap : Form
    {
        public Form_NhaCungCap()
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
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_ncc", conn);
            adt.SelectCommand = cmd;
            adt.Fill(dtSV);
            dgv2.DataSource = dtSV;
        }

        void ThemSuaXoaDGV()
        {
            // Thêm nè
            adt.InsertCommand = new SqlCommand("INSERT INTO tbl_ncc VALUES(@ma_ncc,@ten_ncc,@sodienthoai,@diachi)", conn);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@ma_ncc";
            p1.SourceColumn = "ma_ncc";
            adt.InsertCommand.Parameters.Add(p1);
            //
            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@ten_ncc";
            p2.SourceColumn = "ten_ncc";
            adt.InsertCommand.Parameters.Add(p2);

            SqlParameter p21 = new SqlParameter();
            p21.ParameterName = "@sodienthoai";
            p21.SourceColumn = "sodienthoai";
            adt.InsertCommand.Parameters.Add(p21);

            SqlParameter p22 = new SqlParameter();
            p22.ParameterName = "@diachi";
            p22.SourceColumn = "diachi";
            adt.InsertCommand.Parameters.Add(p22);

            // Sửa nè
            adt.UpdateCommand = new SqlCommand("UPDATE tbl_ncc SET ten_ncc = @ten_ncc, sodienthoai = @sodienthoai, diachi = @diachi WHERE ma_ncc = @ma_ncc", conn);
            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@ma_ncc";
            p3.SourceColumn = "ma_ncc";
            adt.UpdateCommand.Parameters.Add(p3);
            //
            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@ten_ncc";
            p4.SourceColumn = "ten_ncc";
            adt.UpdateCommand.Parameters.Add(p4);

            SqlParameter p31 = new SqlParameter();
            p31.ParameterName = "@sodienthoai";
            p31.SourceColumn = "sodienthoai";
            adt.UpdateCommand.Parameters.Add(p31);
            //
            SqlParameter p41 = new SqlParameter();
            p41.ParameterName = "@diachi";
            p41.SourceColumn = "diachi";
            adt.UpdateCommand.Parameters.Add(p41);

            // Xóa nèk
            adt.DeleteCommand = new SqlCommand("DELETE FROM tbl_ncc WHERE ma_ncc = @ma_ncc", conn);
            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@ma_ncc";
            p5.SourceColumn = "ma_ncc";
            adt.DeleteCommand.Parameters.Add(p5);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_NhaCungCap_Load(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_ncc WHERE ma_ncc = '" + tukhoa + "' OR ten_ncc LIKE N'%" + tukhoa + "%'", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv2.DataSource = dtSV;
            }
            else
            {
                dtSV.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_ncc", conn);
                adt.SelectCommand = cmd;
                adt.Fill(dtSV);
                dgv2.DataSource = dtSV;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Text = dgv2.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete FROM tbl_ncc WHERE ma_ncc = '" + Text + "'", conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                Loaddulieu();
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi bảng khóa ngoại nè.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            them_ncc them_ncc = new them_ncc();
            them_ncc.ShowDialog();
            Loaddulieu();
        }

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update_ncc update_ncc = new update_ncc();
            update_ncc.textBox1.Text = dgv2.CurrentRow.Cells[0].Value.ToString();
            update_ncc.textBox2.Text = dgv2.CurrentRow.Cells[1].Value.ToString();
            update_ncc.textBox4.Text = dgv2.CurrentRow.Cells[2].Value.ToString();
            update_ncc.textBox3.Text = dgv2.CurrentRow.Cells[3].Value.ToString();
            update_ncc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adt.Update((DataTable)dgv2.DataSource);
                Loaddulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
