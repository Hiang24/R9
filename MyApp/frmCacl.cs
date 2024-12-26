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
    public partial class frmCacl : Form
    {
        public frmCacl()
        {
            InitializeComponent();
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //Lấy giá trị của số 1
            //Lấy giá trị của số 2
            //Hiển thị kết quả

            string sSo1 = txt_a.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txt_b.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);

            decimal dKQ = dSo1 + dSo2;

            txt_c.Text = dKQ.ToString();
        }
    }
}
