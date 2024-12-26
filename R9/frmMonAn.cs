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

namespace ChickenPlus
{
    public partial class frmMonAn : Form
    {
        string sCon = "Data Source=LAPTOP-K7AN39RB;Initial Catalog=ChickenPlus;Integrated Security=True;TrustServerCertificate=True";
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
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
            string sQuery = "select * from monan";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonAn");
            dataGridView1.DataSource = ds.Tables["MonAn"];
            con.Close();
        }

        private void TaoMA_Click(object sender, EventArgs e)
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
            // Lấy dữ liệu từ các textbox trên form
            string sMaMA = MaMA.Text;        // Mã món ăn
            string sTenMonAn = TenMA.Text; // Tên món ăn
            string sDonGia = DonGia.Text;    // Đơn giá
                                             // Kiểm tra tính hợp lệ của Mã món ăn
            if (string.IsNullOrEmpty(sMaMA) || sMaMA.Length != 6)
            {
                MessageBox.Show("Mã món ăn không hợp lệ! Vui lòng nhập đúng 6 ký tự.");
                return;
            }

            // Kiểm tra tính hợp lệ của Tên món ăn
            if (string.IsNullOrEmpty(sTenMonAn))
            {
                MessageBox.Show("Tên món ăn không được để trống.");
                return;
            }

            // Kiểm tra tính hợp lệ của Đơn giá
            if (string.IsNullOrEmpty(sDonGia) || !int.TryParse(sDonGia, out int iDonGia) || iDonGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ! Vui lòng nhập số nguyên dương.");
                return;
            }
            string sQuery = "insert into monan values (@MaMA, @TenMA, @DG)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMA", sMaMA);
            cmd.Parameters.AddWithValue("@TenMA", sTenMonAn);
            cmd.Parameters.AddWithValue("@DG", sDonGia);
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

        private void SuaMA_Click(object sender, EventArgs e)
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
            // Lấy dữ liệu từ các textbox trên form
            string sMaMA = MaMA.Text;        // Mã món ăn
            string sTenMonAn = TenMA.Text; // Tên món ăn
            string sDonGia = DonGia.Text;    // Đơn giá
                                             // Kiểm tra tính hợp lệ của Mã món ăn
            if (string.IsNullOrEmpty(sMaMA) || sMaMA.Length != 6)
            {
                MessageBox.Show("Mã món ăn không hợp lệ! Vui lòng nhập đúng 6 ký tự.");
                return;
            }

            // Kiểm tra tính hợp lệ của Tên món ăn
            if (string.IsNullOrEmpty(sTenMonAn))
            {
                MessageBox.Show("Tên món ăn không được để trống.");
                return;
            }

            // Kiểm tra tính hợp lệ của Đơn giá
            if (string.IsNullOrEmpty(sDonGia) || !int.TryParse(sDonGia, out int iDonGia) || iDonGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ! Vui lòng nhập số nguyên dương.");
                return;
            }
            string sQuery = "update monan set tenmonan=@TenMA,dongia= @DG where mama = @mama";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMA", sMaMA);
            cmd.Parameters.AddWithValue("@TenMA", sTenMonAn);
            cmd.Parameters.AddWithValue("@DG", sDonGia);
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
            MaMA.Text = dataGridView1.Rows[e.RowIndex].Cells["MaMA"].Value.ToString();
            TenMA.Text = dataGridView1.Rows[e.RowIndex].Cells["tenmonan"].Value.ToString();
            DonGia.Text = dataGridView1.Rows[e.RowIndex].Cells["dongia"].Value.ToString();
            MaMA.Enabled = false;
        }

        private void XoaMA_Click(object sender, EventArgs e)
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
            string sMaMA = MaMA.Text;
            string sQuery = "delete monan where mama = @mama";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMA", sMaMA);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
