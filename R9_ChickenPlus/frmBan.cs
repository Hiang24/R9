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

            // Bước 2: Chuẩn bị dữ liệu
            string sSoBan = txtSoBan.Text.Trim();
            string sLoaiB = txtLoaiB.Text.Trim();
            string sMaKH = txtMaKH.Text.Trim();

            // Kiểm tra tính hợp lệ của sSoBan
            if (!System.Text.RegularExpressions.Regex.IsMatch(sSoBan, @"^B\d{5}$"))
            {
                MessageBox.Show("Số bàn không hợp lệ! Số bàn phải gồm 6 kí tự có định dạng: B + 5 số nguyên (VD: B00001)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu số bàn không hợp lệ
            }
            // Kiểm tra tính hợp lệ của sLoaiB
            if (!new[] { "A", "B", "C", "D", "E" }.Contains(sLoaiB.ToUpper()))
            {
                MessageBox.Show("Loại bàn không hợp lệ! Vui lòng nhập một trong các loại: A, B, C, D, E",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu loại bàn không hợp lệ
            }
            // Kiểm tra tính hợp lệ của sMaKH (6 ký tự, bắt đầu bằng KH, tiếp theo là 4 số)
            if (!string.IsNullOrEmpty(sMaKH) && !System.Text.RegularExpressions.Regex.IsMatch(sMaKH, @"^KH\d{4}$"))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Mã khách hàng phải có đúng 6 ký tự, bắt đầu bằng 'KH' và theo sau là 4 số nguyên (VD: KH0001)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu mã khách hàng không hợp lệ
            }

            string sQuery = "INSERT INTO BAN VALUES (@soban, @loaib, @makh)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@soban", sSoBan);
            cmd.Parameters.AddWithValue("@loaib", sLoaiB);
            cmd.Parameters.AddWithValue("@makh", sMaKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm mới hoặc mã số bàn đã tồn tại.\nVui lòng kiểm tra lại");
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
            // Kiểm tra tính hợp lệ của sLoaiB
            if (!new[] { "A", "B", "C", "D", "E" }.Contains(sLoaiB.ToUpper()))
            {
                MessageBox.Show("Loại bàn không hợp lệ! Vui lòng nhập một trong các loại: A, B, C, D, E",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu loại bàn không hợp lệ
            }
            // Kiểm tra tính hợp lệ của sMaKH (6 ký tự, bắt đầu bằng KH, tiếp theo là 4 số)
            if (!string.IsNullOrEmpty(sMaKH) && !System.Text.RegularExpressions.Regex.IsMatch(sMaKH, @"^KH\d{4}$"))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ! Mã khách hàng phải có đúng 6 ký tự, bắt đầu bằng 'KH' và theo sau là 4 số nguyên (VD: KH0001)",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close(); // Đóng kết nối nếu mở
                return; // Dừng thực hiện nếu mã khách hàng không hợp lệ
            }
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

        private void toolTipSoBan_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtSoBan_Click(object sender, EventArgs e)
        {
            toolTipSoBan.Show("Nhập mã bàn theo định dạng B + số bàn và tối đa 6 kí tự (VD: B000001)", txtSoBan, 0, txtSoBan.Height, 3000);
        }

        private void txtLoaiB_Click(object sender, EventArgs e)
        {
            toolTipLoaiB.Show("Nhập loại bàn theo 5 loại sau: A, B, C, D, E", txtLoaiB, 0, txtLoaiB.Height, 3000);

        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            toolTipMaKH.Show("Nhập mã khách hàng theo cú pháp KH + số khách hàng và tối đa 6 kí tự (VD: KH0001)", txtMaKH, 0, txtMaKH.Height, 3000);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoBan_Enter(object sender, EventArgs e)
        {
            toolTipSoBan.Show("Nhập mã bàn theo định dạng B + số bàn và tối đa 6 kí tự (VD: B000001)", txtSoBan, 0, txtSoBan.Height, 3000);
        }

        private void txtLoaiB_Enter(object sender, EventArgs e)
        {
            toolTipLoaiB.Show("Nhập loại bàn theo 5 loại sau: A, B, C, D, E", txtLoaiB, 0, txtLoaiB.Height, 3000);
        }
        private void txtMaKH_Enter(object sender, EventArgs e)
        {
            toolTipMaKH.Show("Nhập mã khách hàng theo cú pháp KH + số khách hàng và tối đa 6 kí tự (VD: KH0001)", txtMaKH, 0, txtMaKH.Height, 3000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
