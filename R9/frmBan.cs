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

namespace LamViecVoiData
{
    public partial class frmBan : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;TrustServerCertificate=True";

        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi");
            }
            string sQuery = "SELECT * FROM BAN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "frmBan");

            dataGridViewBan.DataSource = ds.Tables["frmBan"];
            con.Close();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoBan.Text = dataGridViewBan.Rows[e.RowIndex].Cells["SoBan"].Value.ToString();
            txtLoaiB.Text = dataGridViewBan.Rows[e.RowIndex].Cells["LoaiB"].Value.ToString();
            txtMaKH.Text = dataGridViewBan.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();

            txtSoBan.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối DataBase");
            }

            //Bước 2: Chuẩn bị dữ liệu
            //Kiểm tra tính hợp lệ
            string sSoBan = txtSoBan.Text;
            string sLoaiB = txtLoaiB.Text;
            string sMaKH = txtMaKH.Text;

            string sQuery = "INSERT INTO BAN VALUES (@soban, @loaib, @makh)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@soban", sMaKH);
            cmd.Parameters.AddWithValue("@loaib", sLoaiB);
            cmd.Parameters.AddWithValue("@makh", sMaKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm mới");
            }
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối DataBase");
            }

            string sSoBan = txtSoBan.Text;
            string sLoaiB = txtLoaiB.Text;
            string sMaKH = txtMaKH.Text;

            string sQuery = "UPDATE BAN SET LoaiB = @loaib , MaKH = @makh WHERE SoBan = @soban";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@soban", sSoBan);
            cmd.Parameters.AddWithValue("@loaib", sLoaiB);
            cmd.Parameters.AddWithValue("@makh", sMaKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật");
            }
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối DataBase");
            }

            string sSoBan = txtSoBan.Text;

            string sQuery = "DELETE FROM BAN WHERE SoBan = @soban";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@soban", sSoBan);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa");
            }
            con.Close();
        }

        private void btnXoaMaKH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối DataBase");
            }

            string sSoBan = txtSoBan.Text;

            string sQuery = "UPDATE BAN SET MaKH = NULL WHERE SoBan = @soban";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@soban", sSoBan);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa");
            }
            con.Close();
        }
    }
}
