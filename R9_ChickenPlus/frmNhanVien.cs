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
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChickenPlus
{
    public partial class frmNhanVien : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void taonv_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!");
            }
            //Chuẩn bị dữ liệu
            string sMaNV = MaNV.Text;
            string sTenNV = TenNV.Text;
            string sNgaySinh = NgaySinh.Value.ToString("yyyy-MM-dd");
            string sTenDangNhap = tendangnhap.Text;
            string sDiaChi = dc.Text;
            string sSDT = sdt.Text;
            string sVaiTro = vaitro1.Text;
            string sCaLam = CaLamViec.Text;
            //Kiểm tra hợp lệ
            // Kiểm tra tính hợp lệ của Mã nhân viên
            if (string.IsNullOrEmpty(sMaNV) || sMaNV.Length != 6)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ! Vui lòng nhập đúng 6 ký tự.");
                return;
            }
            // Ktr thl Tên đăng nhập
            if (string.IsNullOrEmpty(sTenDangNhap) || sTenDangNhap.Length > 10)
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ! Vui lòng nhập dưới 10 ký tự.");
                return;
            }
            // Kiểm tra tính hợp lệ của Tên nhân viên
            if (string.IsNullOrEmpty(sTenNV))
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                return;
            }

            // Kiểm tra tính hợp lệ của Ngày sinh
            DateTime ngaySinh;
            if (!DateTime.TryParse(sNgaySinh, out ngaySinh) || ngaySinh >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Ngày sinh phải nhỏ hơn ngày hiện tại.");
                return;
            }

            // Kiểm tra tính hợp lệ của Số điện thoại
            if (string.IsNullOrEmpty(sSDT) || sSDT.Length != 10 || !IsDigitsOnly(sSDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 chữ số.");
                return;
            }

            // Kiểm tra tính hợp lệ của Ca làm
            if (string.IsNullOrEmpty(sCaLam))
            {
                MessageBox.Show("Vui lòng chọn ca làm!");
                return;
            }

            // Nếu tất cả đều hợp lệ
            MessageBox.Show("Tất cả thông tin đã hợp lệ! Sẵn sàng lưu vào cơ sở dữ liệu.");

            // Hàm kiểm tra chỉ chứa chữ số
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
                return true;
            }
            string sQuery = "insert into nhanvien values (@MaNV, @TenDN, @HoTen, @NgaySinh, @Sdt, @diachi, @vaitro, @calam)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@TenDN", sTenDangNhap);
            cmd.Parameters.AddWithValue("@HoTen", sTenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@Sdt", sSDT);
            cmd.Parameters.AddWithValue("@diachi", sDiaChi);
            cmd.Parameters.AddWithValue("@vaitro", sVaiTro);
            cmd.Parameters.AddWithValue("@calam", sCaLam);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công!");
            }
            catch (Exception ex) { 
            MessageBox.Show("Xảy ra lỗi trong quá trình tạo!");
            }
            con.Close();
        }

        private void huytao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!");
            }
            //Chuẩn bị dữ liệu
            string sMaNV = MaNV.Text;
            string sQuery = "delete nhanvien where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa!");
            }
            con.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!");
            }
            string sQuery = "select * from nhanvien";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhanVien");
            dataGridView1.DataSource = ds.Tables["NhanVien"];
            con.Close();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hẹn gặp lại!","Thông báo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            TenNV.Text = dataGridView1.Rows[e.RowIndex].Cells["HoVaTen"].Value.ToString();
            tendangnhap.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            dc.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            vaitro1.Text = dataGridView1.Rows[e.RowIndex].Cells["VaiTro"].Value.ToString();
            CaLamViec.Text = dataGridView1.Rows[e.RowIndex].Cells["CaLamViec"].Value.ToString();
            sdt.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            NgaySinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            MaNV.Enabled = false;
        }

        private void Suanhanvien_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!");
            }
            string sMaNV = MaNV.Text;
            string sTenNV = TenNV.Text;
            string sNgaySinh = NgaySinh.Value.ToString("yyyy-MM-dd");
            string sTenDangNhap = tendangnhap.Text;
            string sDiaChi = dc.Text;
            string sSDT = sdt.Text;
            string sVaiTro = vaitro1.Text;
            string sCaLam = CaLamViec.Text;
            // Ktr thl Tên đăng nhập
            if (string.IsNullOrEmpty(sTenDangNhap) || sTenDangNhap.Length > 10)
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ! Vui lòng nhập dưới 10 ký tự.");
                return;
            }
            // Kiểm tra tính hợp lệ của Tên nhân viên
            if (string.IsNullOrEmpty(sTenNV))
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                return;
            }

            // Kiểm tra tính hợp lệ của Ngày sinh
            DateTime ngaySinh;
            if (!DateTime.TryParse(sNgaySinh, out ngaySinh) || ngaySinh >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Ngày sinh phải nhỏ hơn ngày hiện tại.");
                return;
            }

            // Kiểm tra tính hợp lệ của Số điện thoại
            if (string.IsNullOrEmpty(sSDT) || sSDT.Length != 10 || !IsDigitsOnly(sSDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 chữ số.");
                return;
            }

            // Kiểm tra tính hợp lệ của Ca làm
            if (string.IsNullOrEmpty(sCaLam))
            {
                MessageBox.Show("Vui lòng chọn ca làm!");
                return;
            }

            // Nếu tất cả đều hợp lệ
            MessageBox.Show("Tất cả thông tin đã hợp lệ! Sẵn sàng lưu vào cơ sở dữ liệu.");

            // Hàm kiểm tra chỉ chứa chữ số
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
                return true;
            }
            string sQuery = "update nhanvien set TenDangNhap=@TenDN, HoVaTen=@HoTen, NgaySinh=@NgaySinh,SDT= @Sdt, DiaChi=@diachi,VaiTro= @vaitro,CaLamViec= @calam where MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("TenDN", sTenDangNhap);
            cmd.Parameters.AddWithValue("@HoTen", sTenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@Sdt", sSDT);
            cmd.Parameters.AddWithValue("@diachi", sDiaChi);
            cmd.Parameters.AddWithValue("@vaitro", sVaiTro);
            cmd.Parameters.AddWithValue("@calam", sCaLam);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }
            con.Close();
        }
    }
}
