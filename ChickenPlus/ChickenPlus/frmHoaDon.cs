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
    public partial class frmHoaDon : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void manv_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
            string sQuery = "select * from hoadon";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDon");
            dataGridView1.DataSource = ds.Tables["HoaDon"];
            con.Close();
        }

        private void taohd_Click(object sender, EventArgs e)
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
            string sMaHD = mahd1.Text; // Mã hóa đơn
            string sMaNV = manv1.Text; // Mã nhân viên
            string sNgayTao = ngaytao1.Value.ToString("yyyy-MM-dd"); // Ngày tạo (DateTimePicker)
            string sGioVao = ngaytao1.Value.ToString("HH:mm"); // Giờ vào (DateTimePicker)
            string sGioRa = giora1.Value.ToString("HH:mm"); // Giờ ra (DateTimePicker)

            int iTongTien = 0;
            int iTienKhachDua = 0;
            int iTienThoiLai = 0;
            int iSoDiemSD = 0;

            // Chuyển đổi các giá trị số
            int.TryParse(tongtien1.Text, out iTongTien);
            int.TryParse(tienkhachdua1.Text, out iTienKhachDua);
            int.TryParse(tienthoi1.Text, out iTienThoiLai);
            int.TryParse(sodiem1.Text, out iSoDiemSD);
            // Kiểm tra Mã hóa đơn
            if (string.IsNullOrEmpty(sMaHD) || sMaHD.Length != 6)
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ! Vui lòng nhập đúng mã (6 ký tự).");
                return;
            }

            // Kiểm tra Mã nhân viên
            if (string.IsNullOrEmpty(sMaNV) || sMaNV.Length != 6)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ! Vui lòng nhập đúng mã (6 ký tự).");
                return;
            }

            // Kiểm tra Ngày tạo
            if (DateTime.Parse(sNgayTao) > DateTime.Now)
            {
                MessageBox.Show("Ngày tạo hóa đơn không hợp lệ! Ngày tạo không được lớn hơn ngày hiện tại.");
                return;
            }

            // Kiểm tra Giờ vào và Giờ ra
            if (DateTime.Parse(sGioRa) <= DateTime.Parse(sGioVao))
            {
                MessageBox.Show("Giờ ra không hợp lệ! Giờ ra phải lớn hơn giờ vào.");
                return;
            }

            // Kiểm tra Tổng tiền, Tiền khách đưa, Tiền thối lại và Số điểm sử dụng
            if (iTongTien < 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ! Tổng tiền phải lớn hơn hoặc bằng 0.");
                return;
            }

            if (iTienKhachDua < iTongTien)
            {
                MessageBox.Show("Tiền khách đưa không hợp lệ! Tiền khách đưa phải lớn hơn hoặc bằng tổng tiền.");
                return;
            }

            if (iTienThoiLai != (iTienKhachDua - iTongTien))
            {
                MessageBox.Show("Tiền thối lại không hợp lệ! Tiền thối lại phải bằng tiền khách đưa trừ tổng tiền.");
                return;
            }

            if (iSoDiemSD < 0)
            {
                MessageBox.Show("Số điểm sử dụng không hợp lệ! Số điểm phải lớn hơn hoặc bằng 0.");
                return;
            }

            // Nếu hợp lệ
            MessageBox.Show("Dữ liệu hợp lệ! Tiếp tục xử lý...");
            string sQuery = "INSERT INTO HOADON (MaHD, MaNV, NgayTao, GioVao, GioRa, TongTien, TienKhachDua, TienThoiLai, SoDiemSD) " +
               "VALUES (@MaHD, @MaNV, @NgayTao, @GioVao, @GioRa, @TongTien, @TienKhachDua, @TienThoiLai, @SoDiemSD)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@NgayTao", sNgayTao);
            cmd.Parameters.AddWithValue("@GioVao", sGioVao);
            cmd.Parameters.AddWithValue("@GioRa", sGioRa);
            cmd.Parameters.AddWithValue("@TongTien", iTongTien);
            cmd.Parameters.AddWithValue("@TienKhachDua", iTienKhachDua);
            cmd.Parameters.AddWithValue("@TienThoiLai", iTienThoiLai);
            cmd.Parameters.AddWithValue("@SoDiemSD", iSoDiemSD);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tạo!");
            }
            con.Close();
        }

        private void Suahd_Click(object sender, EventArgs e)
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
            string sMaHD = mahd1.Text; // Mã hóa đơn
            string sMaNV = manv1.Text; // Mã nhân viên
            string sNgayTao = ngaytao1.Value.ToString("yyyy-MM-dd"); // Ngày tạo (DateTimePicker)
            string sGioVao = ngaytao1.Value.ToString("HH:mm"); // Giờ vào (DateTimePicker)
            string sGioRa = giora1.Value.ToString("HH:mm"); // Giờ ra (DateTimePicker)

            int iTongTien = 0;
            int iTienKhachDua = 0;
            int iTienThoiLai = 0;
            int iSoDiemSD = 0;

            // Chuyển đổi các giá trị số
            int.TryParse(tongtien1.Text, out iTongTien);
            int.TryParse(tienkhachdua1.Text, out iTienKhachDua);
            int.TryParse(tienthoi1.Text, out iTienThoiLai);
            int.TryParse(sodiem1.Text, out iSoDiemSD);
            // Kiểm tra Mã hóa đơn
            if (string.IsNullOrEmpty(sMaHD) || sMaHD.Length != 6)
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ! Vui lòng nhập đúng mã (6 ký tự).");
                return;
            }

            // Kiểm tra Mã nhân viên
            if (string.IsNullOrEmpty(sMaNV) || sMaNV.Length != 6)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ! Vui lòng nhập đúng mã (6 ký tự).");
                return;
            }

            // Kiểm tra Ngày tạo
            if (DateTime.Parse(sNgayTao) > DateTime.Now)
            {
                MessageBox.Show("Ngày tạo hóa đơn không hợp lệ! Ngày tạo không được lớn hơn ngày hiện tại.");
                return;
            }

            // Kiểm tra Giờ vào và Giờ ra
            if (DateTime.Parse(sGioRa) <= DateTime.Parse(sGioVao))
            {
                MessageBox.Show("Giờ ra không hợp lệ! Giờ ra phải lớn hơn giờ vào.");
                return;
            }

            // Kiểm tra Tổng tiền, Tiền khách đưa, Tiền thối lại và Số điểm sử dụng
            if (iTongTien < 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ! Tổng tiền phải lớn hơn hoặc bằng 0.");
                return;
            }

            if (iTienKhachDua < iTongTien)
            {
                MessageBox.Show("Tiền khách đưa không hợp lệ! Tiền khách đưa phải lớn hơn hoặc bằng tổng tiền.");
                return;
            }

            if (iTienThoiLai != (iTienKhachDua - iTongTien))
            {
                MessageBox.Show("Tiền thối lại không hợp lệ! Tiền thối lại phải bằng tiền khách đưa trừ tổng tiền.");
                return;
            }

            if (iSoDiemSD < 0)
            {
                MessageBox.Show("Số điểm sử dụng không hợp lệ! Số điểm phải lớn hơn hoặc bằng 0.");
                return;
            }

            // Nếu hợp lệ
            MessageBox.Show("Dữ liệu hợp lệ! Tiếp tục xử lý...");
            string sQuery = "update HOADON set MaNV=@MaNV, NgayTao=@NgayTao, GioVao=@GioVao, GioRa=@GioRa, TongTien=@TongTien, TienKhachDua=@TienKhachDua, TienThoiLai=@TienThoiLai, SoDiemSD =@SoDiemSD where MaHD = @MaHD";
               
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@NgayTao", sNgayTao);
            cmd.Parameters.AddWithValue("@GioVao", sGioVao);
            cmd.Parameters.AddWithValue("@GioRa", sGioRa);
            cmd.Parameters.AddWithValue("@TongTien", iTongTien);
            cmd.Parameters.AddWithValue("@TienKhachDua", iTienKhachDua);
            cmd.Parameters.AddWithValue("@TienThoiLai", iTienThoiLai);
            cmd.Parameters.AddWithValue("@SoDiemSD", iSoDiemSD);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mahd1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            manv1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            ngaytao1.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayTao"].Value.ToString();
            giovao1.Text = dataGridView1.Rows[e.RowIndex].Cells["GioVao"].Value.ToString();
            giora1.Text = dataGridView1.Rows[e.RowIndex].Cells["GioRa"].Value.ToString();
            tongtien1.Text = dataGridView1.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            tienkhachdua1.Text = dataGridView1.Rows[e.RowIndex].Cells["TienKhachDua"].Value.ToString();
            tienthoi1.Text = dataGridView1.Rows[e.RowIndex].Cells["TienThoiLai"].Value.ToString();
            sodiem1.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDiemSD"].Value.ToString();
        }

        private void xoahd_Click(object sender, EventArgs e)
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
            string sMaHD = mahd1.Text; // Mã hóa đơn
            string sQuery = "delete HOADON  where MaHD = @MaHD";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
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
    }
}
