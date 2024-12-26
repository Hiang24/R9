using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            MessageBox.Show("Bố mày thấy mày lưu rồi. Mày vừa nhập: "+ sMaKH);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Xin hãy chờ đợi một chút");
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Địt mẹ nhà mày :)))","Xin thông báo với chúng mày");
        }
    }
}
