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
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;TrustServerCertificate=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Bước 1: Kết nối thành công
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
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSDT = txtSDT.Text;

            // Kiểm tra tính hợp lệ của sMaKH (6 ký tự, bắt đầu bằng KH, tiếp theo là 4 số)
            if (!string.IsNullOrEmpty(sMaKH) && !System.Text.RegularExpressions.Regex.IsMatch(sMaKH, @"^KH\d{4}$"))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Mã khách hàng phải có đúng 6 ký tự, bắt đầu bằng 'KH' và theo sau là 4 số nguyên (VD: KH0001)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu mã khách hàng không hợp lệ
            }

            // Kiểm tra tính hợp lệ của sSDT (bắt đầu bằng 09, không khoảng trắng, chỉ chứa số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(sSDT, @"^09\d{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng '09' và có đúng 10 chữ số (VD: 0912345678)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu số điện thoại không hợp lệ
            }

            string sQuery = "INSERT INTO KHACHHANG VALUES (@makh, @tenkh, @sdt)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@sdt", sSDT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm mới hoặc mã khách hàng đã tồn tại.\nVui lòng kiểm tra lại");
            }
            con.Close();
        }

        private void BangKhachHang_Load(object sender, EventArgs e)
        {
            //Bước 1: Kết nối thành công
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi");
            }
            //Bước 2: Lấy dữ liệu về
            string sQuery = "SELECT * FROM KHACHHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "BangKhachHang");

            dataGridView1.DataSource = ds.Tables["BangKhachHang"];
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();

            txtMaKH.Enabled = false;
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

            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSDT = txtSDT.Text;

            // Kiểm tra tính hợp lệ của sMaKH (6 ký tự, bắt đầu bằng KH, tiếp theo là 4 số)
            if (!string.IsNullOrEmpty(sMaKH) && !System.Text.RegularExpressions.Regex.IsMatch(sMaKH, @"^KH\d{4}$"))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Mã khách hàng phải có đúng 6 ký tự, bắt đầu bằng 'KH' và theo sau là 4 số nguyên (VD: KH0001)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu mã khách hàng không hợp lệ
            }

            // Kiểm tra tính hợp lệ của sSDT (bắt đầu bằng 09, không khoảng trắng, chỉ chứa số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(sSDT, @"^09\d{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng '09' và có đúng 10 chữ số (VD: 0912345678)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu số điện thoại không hợp lệ
            }

            string sQuery = "UPDATE KHACHHANG SET TenKH = @tenkh , SDT = @sdt WHERE MaKH = @makh";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@sdt", sSDT);

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

            string sMaKH = txtMaKH.Text;

            string sQuery = "DELETE FROM KHACHHANG WHERE MaKH = @makh";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin khách hàng thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa thông tin");
            }
            con.Close();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_Enter(object sender, EventArgs e)
        {
            toolTipMaKH.Show("Nhập mã khách hàng theo cú pháp KH + số khách hàng và tối đa 6 kí tự (VD: KH0001)", txtMaKH, 0, txtMaKH.Height, 3000);
        }
    }
}
