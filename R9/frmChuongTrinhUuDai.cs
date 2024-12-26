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

namespace LamViecVoiData
{
    public partial class frmChuongTrinhUuDai : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;TrustServerCertificate=True";
        public frmChuongTrinhUuDai()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmChuongTrinhUuDai_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã có lỗi trong quá trình kết nối");
            }

            string sQuery = "SELECT * FROM CHUONGTRINHUUDAI";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery,con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "frmChuongTrinhUuDai");
            dataGridViewCTUD.DataSource = ds.Tables["frmChuongTrinhUuDai"];

            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã có lỗi trong quá trình kết nối");
            }

            string sMaUD = txtMaUD.Text;
            string sThongTinUD = txtThongTinUD.Text;
            string sTenUD = txtTenUD.Text;
            string sNgayBD = dtNgayBD.Value.ToString("yyyy-MM-dd");
            string sNgayKT = dtNgayKT.Value.ToString("yyyy-MM-dd");

            string sQuery = "INSERT INTO CHUONGTRINHUUDAI VALUES (@maud, @ttud, @tenud, @ngaybd, @ngaykt)";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@maud", sMaUD);
            cmd.Parameters.AddWithValue("@ttud", sThongTinUD);
            cmd.Parameters.AddWithValue("@tenud", sTenUD);
            cmd.Parameters.AddWithValue("@ngaybd", sNgayBD);
            cmd.Parameters.AddWithValue("@ngaykt", sNgayKT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình thêm thông tin");
            }

            con.Close();
        }

        private void dataGridViewCTUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNgayBD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCTUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaUD.Text = dataGridViewCTUD.Rows[e.RowIndex].Cells["MaUD"].Value.ToString();
            txtThongTinUD.Text = dataGridViewCTUD.Rows[e.RowIndex].Cells["ThongTinUD"].Value.ToString();
            txtTenUD.Text = dataGridViewCTUD.Rows[e.RowIndex].Cells["TenCTUD"].Value.ToString();
            dtNgayBD.Value = Convert.ToDateTime(dataGridViewCTUD.Rows[e.RowIndex].Cells["NgayBatDau"].Value);
            dtNgayKT.Value = Convert.ToDateTime(dataGridViewCTUD.Rows[e.RowIndex].Cells["NgayKetThuc"].Value);

            txtMaUD.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã có lỗi trong quá trình kết nối");
            }

            string sMaUD = txtMaUD.Text;
            string sThongTinUD = txtThongTinUD.Text;
            string sTenUD = txtTenUD.Text;
            string sNgayBD = dtNgayBD.Value.ToString("yyyy-MM-dd");
            string sNgayKT = dtNgayKT.Value.ToString("yyyy-MM-dd");

            string sQuery = "UPDATE CHUONGTRINHUUDAI SET ThongTinUD = @ttud, TenCTUD = @tenud, NgayBatDau = @ngaybd, NgayKetThuc = @ngaykt WHERE MaUD = @maud";

            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@maud", sMaUD);
            cmd.Parameters.AddWithValue("@ttud", sThongTinUD);
            cmd.Parameters.AddWithValue("@tenud", sTenUD);
            cmd.Parameters.AddWithValue("@ngaybd", sNgayBD);
            cmd.Parameters.AddWithValue("@ngaykt", sNgayKT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật thông tin");
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
            catch (Exception ex)
            {

                MessageBox.Show("Đã có lỗi trong quá trình kết nối");
            }

            string sMaUD = txtMaUD.Text;

            string sQuery = "DELETE FROM CHUONGTRINHUUDAI WHERE MaUD = @maud";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maud", sMaUD);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
            }

            con.Close();
        }
    }
}
