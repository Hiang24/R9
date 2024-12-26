namespace ChickenPlus
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.taonv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xoanhanvien = new System.Windows.Forms.Button();
            this.Vaitro = new System.Windows.Forms.Label();
            this.calam = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.TextBox();
            this.CaLamViec = new System.Windows.Forms.TextBox();
            this.vaitro1 = new System.Windows.Forms.TextBox();
            this.Suanhanvien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // MaNV
            // 
            this.MaNV.Location = new System.Drawing.Point(251, 126);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(242, 22);
            this.MaNV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TenNV
            // 
            this.TenNV.Location = new System.Drawing.Point(251, 168);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(242, 22);
            this.TenNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(705, 126);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(209, 22);
            this.sdt.TabIndex = 4;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(705, 168);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(209, 22);
            this.dc.TabIndex = 5;
            // 
            // taonv
            // 
            this.taonv.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.taonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taonv.Location = new System.Drawing.Point(577, 330);
            this.taonv.Name = "taonv";
            this.taonv.Size = new System.Drawing.Size(99, 41);
            this.taonv.TabIndex = 8;
            this.taonv.Text = "Tạo";
            this.taonv.UseVisualStyleBackColor = false;
            this.taonv.Click += new System.EventHandler(this.taonv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày sinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(251, 261);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(242, 22);
            this.NgaySinh.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 212);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // xoanhanvien
            // 
            this.xoanhanvien.BackColor = System.Drawing.Color.Firebrick;
            this.xoanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoanhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoanhanvien.Location = new System.Drawing.Point(825, 330);
            this.xoanhanvien.Name = "xoanhanvien";
            this.xoanhanvien.Size = new System.Drawing.Size(89, 41);
            this.xoanhanvien.TabIndex = 10;
            this.xoanhanvien.Text = "Xóa";
            this.xoanhanvien.UseVisualStyleBackColor = false;
            this.xoanhanvien.Click += new System.EventHandler(this.huytao_Click);
            // 
            // Vaitro
            // 
            this.Vaitro.AutoSize = true;
            this.Vaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaitro.Location = new System.Drawing.Point(558, 220);
            this.Vaitro.Name = "Vaitro";
            this.Vaitro.Size = new System.Drawing.Size(65, 20);
            this.Vaitro.TabIndex = 6;
            this.Vaitro.Text = "Vai trò";
            this.Vaitro.Click += new System.EventHandler(this.label5_Click);
            // 
            // calam
            // 
            this.calam.AutoSize = true;
            this.calam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calam.Location = new System.Drawing.Point(558, 266);
            this.calam.Name = "calam";
            this.calam.Size = new System.Drawing.Size(68, 20);
            this.calam.TabIndex = 6;
            this.calam.Text = "Ca làm";
            this.calam.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên đăng nhập";
            // 
            // tendangnhap
            // 
            this.tendangnhap.Location = new System.Drawing.Point(251, 217);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(242, 22);
            this.tendangnhap.TabIndex = 2;
            // 
            // CaLamViec
            // 
            this.CaLamViec.Location = new System.Drawing.Point(705, 266);
            this.CaLamViec.Name = "CaLamViec";
            this.CaLamViec.Size = new System.Drawing.Size(209, 22);
            this.CaLamViec.TabIndex = 7;
            // 
            // vaitro1
            // 
            this.vaitro1.Location = new System.Drawing.Point(705, 220);
            this.vaitro1.Name = "vaitro1";
            this.vaitro1.Size = new System.Drawing.Size(209, 22);
            this.vaitro1.TabIndex = 6;
            // 
            // Suanhanvien
            // 
            this.Suanhanvien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Suanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suanhanvien.Location = new System.Drawing.Point(706, 330);
            this.Suanhanvien.Name = "Suanhanvien";
            this.Suanhanvien.Size = new System.Drawing.Size(89, 41);
            this.Suanhanvien.TabIndex = 16;
            this.Suanhanvien.Text = "Sửa";
            this.Suanhanvien.UseVisualStyleBackColor = false;
            this.Suanhanvien.Click += new System.EventHandler(this.Suanhanvien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LamViecVoiData.Properties.Resources.CK;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1009, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Suanhanvien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.xoanhanvien);
            this.Controls.Add(this.taonv);
            this.Controls.Add(this.vaitro1);
            this.Controls.Add(this.CaLamViec);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.calam);
            this.Controls.Add(this.Vaitro);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tendangnhap);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button taonv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button xoanhanvien;
        private System.Windows.Forms.Label Vaitro;
        private System.Windows.Forms.Label calam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tendangnhap;
        private System.Windows.Forms.TextBox CaLamViec;
        private System.Windows.Forms.TextBox vaitro1;
        private System.Windows.Forms.Button Suanhanvien;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

