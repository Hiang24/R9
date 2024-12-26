using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamViecVoiData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BangKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang khachhang = new frmKhachHang();
            khachhang.MdiParent = this;
            khachhang.Show();
        }

        private void BangBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBan ban = new frmBan();
            ban.MdiParent = this;
            ban.Show();
        }

        private void BangChuongTrinhUuDaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuongTrinhUuDai ctud = new frmChuongTrinhUuDai();
            ctud.MdiParent = this;
            ctud.Show();
        }
    }
}
