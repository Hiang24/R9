﻿namespace ChickenPlus
{
    partial class frmHoaDon
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
            this.mahd = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            this.ngaytao = new System.Windows.Forms.Label();
            this.giora = new System.Windows.Forms.Label();
            this.tienkhachdua = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            this.sodiem = new System.Windows.Forms.Label();
            this.tienthoi = new System.Windows.Forms.Label();
            this.mahd1 = new System.Windows.Forms.TextBox();
            this.manv1 = new System.Windows.Forms.TextBox();
            this.tongtien1 = new System.Windows.Forms.TextBox();
            this.tienkhachdua1 = new System.Windows.Forms.TextBox();
            this.tienthoi1 = new System.Windows.Forms.TextBox();
            this.sodiem1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Suahd = new System.Windows.Forms.Button();
            this.xoahd = new System.Windows.Forms.Button();
            this.taohd = new System.Windows.Forms.Button();
            this.ngaytao1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.giovao1 = new System.Windows.Forms.DateTimePicker();
            this.giora1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mahd
            // 
            this.mahd.AutoSize = true;
            this.mahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahd.Location = new System.Drawing.Point(82, 121);
            this.mahd.Name = "mahd";
            this.mahd.Size = new System.Drawing.Size(106, 20);
            this.mahd.TabIndex = 2;
            this.mahd.Text = "Mã hóa đơn";
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv.Location = new System.Drawing.Point(82, 182);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(120, 20);
            this.manv.TabIndex = 2;
            this.manv.Text = "Mã nhân viên";
            this.manv.Click += new System.EventHandler(this.manv_Click);
            // 
            // ngaytao
            // 
            this.ngaytao.AutoSize = true;
            this.ngaytao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytao.Location = new System.Drawing.Point(82, 241);
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.Size = new System.Drawing.Size(83, 20);
            this.ngaytao.TabIndex = 2;
            this.ngaytao.Text = "Ngày tạo";
            // 
            // giora
            // 
            this.giora.AutoSize = true;
            this.giora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giora.Location = new System.Drawing.Point(82, 325);
            this.giora.Name = "giora";
            this.giora.Size = new System.Drawing.Size(61, 20);
            this.giora.TabIndex = 2;
            this.giora.Text = "Giờ ra";
            // 
            // tienkhachdua
            // 
            this.tienkhachdua.AutoSize = true;
            this.tienkhachdua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienkhachdua.Location = new System.Drawing.Point(329, 182);
            this.tienkhachdua.Name = "tienkhachdua";
            this.tienkhachdua.Size = new System.Drawing.Size(136, 20);
            this.tienkhachdua.TabIndex = 2;
            this.tienkhachdua.Text = "Tiền khách đưa";
            this.tienkhachdua.Click += new System.EventHandler(this.tienkhachdua_Click);
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(329, 121);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(87, 20);
            this.tongtien.TabIndex = 2;
            this.tongtien.Text = "Tổng tiền";
            // 
            // sodiem
            // 
            this.sodiem.AutoSize = true;
            this.sodiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodiem.Location = new System.Drawing.Point(603, 182);
            this.sodiem.Name = "sodiem";
            this.sodiem.Size = new System.Drawing.Size(149, 20);
            this.sodiem.TabIndex = 2;
            this.sodiem.Text = "Số điểm sử dụng";
            this.sodiem.Click += new System.EventHandler(this.sodiem_Click);
            // 
            // tienthoi
            // 
            this.tienthoi.AutoSize = true;
            this.tienthoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienthoi.Location = new System.Drawing.Point(603, 121);
            this.tienthoi.Name = "tienthoi";
            this.tienthoi.Size = new System.Drawing.Size(108, 20);
            this.tienthoi.TabIndex = 2;
            this.tienthoi.Text = "Tiền thối lại";
            // 
            // mahd1
            // 
            this.mahd1.Location = new System.Drawing.Point(209, 120);
            this.mahd1.Name = "mahd1";
            this.mahd1.Size = new System.Drawing.Size(100, 22);
            this.mahd1.TabIndex = 0;
            // 
            // manv1
            // 
            this.manv1.Location = new System.Drawing.Point(209, 181);
            this.manv1.Name = "manv1";
            this.manv1.Size = new System.Drawing.Size(100, 22);
            this.manv1.TabIndex = 1;
            this.manv1.TextChanged += new System.EventHandler(this.manv1_TextChanged);
            // 
            // tongtien1
            // 
            this.tongtien1.Location = new System.Drawing.Point(471, 121);
            this.tongtien1.Name = "tongtien1";
            this.tongtien1.Size = new System.Drawing.Size(100, 22);
            this.tongtien1.TabIndex = 2;
            this.tongtien1.TextChanged += new System.EventHandler(this.tongtien1_TextChanged);
            // 
            // tienkhachdua1
            // 
            this.tienkhachdua1.Location = new System.Drawing.Point(471, 180);
            this.tienkhachdua1.Name = "tienkhachdua1";
            this.tienkhachdua1.Size = new System.Drawing.Size(100, 22);
            this.tienkhachdua1.TabIndex = 3;
            this.tienkhachdua1.TextChanged += new System.EventHandler(this.tienkhachdua1_TextChanged);
            // 
            // tienthoi1
            // 
            this.tienthoi1.Location = new System.Drawing.Point(778, 120);
            this.tienthoi1.Name = "tienthoi1";
            this.tienthoi1.Size = new System.Drawing.Size(129, 22);
            this.tienthoi1.TabIndex = 4;
            // 
            // sodiem1
            // 
            this.sodiem1.Location = new System.Drawing.Point(778, 181);
            this.sodiem1.Name = "sodiem1";
            this.sodiem1.Size = new System.Drawing.Size(129, 22);
            this.sodiem1.TabIndex = 5;
            this.sodiem1.TextChanged += new System.EventHandler(this.sodiem1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 227);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Suahd
            // 
            this.Suahd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Suahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suahd.Location = new System.Drawing.Point(607, 259);
            this.Suahd.Name = "Suahd";
            this.Suahd.Size = new System.Drawing.Size(93, 42);
            this.Suahd.TabIndex = 10;
            this.Suahd.Text = "Sửa";
            this.Suahd.UseVisualStyleBackColor = false;
            this.Suahd.Click += new System.EventHandler(this.Suahd_Click);
            // 
            // xoahd
            // 
            this.xoahd.BackColor = System.Drawing.Color.Firebrick;
            this.xoahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoahd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoahd.Location = new System.Drawing.Point(731, 259);
            this.xoahd.Name = "xoahd";
            this.xoahd.Size = new System.Drawing.Size(101, 42);
            this.xoahd.TabIndex = 11;
            this.xoahd.Text = "Xóa";
            this.xoahd.UseVisualStyleBackColor = false;
            this.xoahd.Click += new System.EventHandler(this.xoahd_Click);
            // 
            // taohd
            // 
            this.taohd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.taohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taohd.Location = new System.Drawing.Point(471, 259);
            this.taohd.Name = "taohd";
            this.taohd.Size = new System.Drawing.Size(105, 42);
            this.taohd.TabIndex = 9;
            this.taohd.Text = "Tạo";
            this.taohd.UseVisualStyleBackColor = false;
            this.taohd.Click += new System.EventHandler(this.taohd_Click);
            // 
            // ngaytao1
            // 
            this.ngaytao1.Location = new System.Drawing.Point(192, 241);
            this.ngaytao1.Name = "ngaytao1";
            this.ngaytao1.Size = new System.Drawing.Size(200, 22);
            this.ngaytao1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ vào";
            // 
            // giovao1
            // 
            this.giovao1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.giovao1.Location = new System.Drawing.Point(192, 283);
            this.giovao1.Name = "giovao1";
            this.giovao1.ShowUpDown = true;
            this.giovao1.Size = new System.Drawing.Size(200, 22);
            this.giovao1.TabIndex = 7;
            // 
            // giora1
            // 
            this.giora1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.giora1.Location = new System.Drawing.Point(192, 325);
            this.giora1.Name = "giora1";
            this.giora1.ShowUpDown = true;
            this.giora1.Size = new System.Drawing.Size(200, 22);
            this.giora1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LamViecVoiData.Properties.Resources.CK;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1009, 616);
            this.Controls.Add(this.giora1);
            this.Controls.Add(this.giovao1);
            this.Controls.Add(this.ngaytao1);
            this.Controls.Add(this.Suahd);
            this.Controls.Add(this.xoahd);
            this.Controls.Add(this.taohd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manv1);
            this.Controls.Add(this.sodiem1);
            this.Controls.Add(this.tongtien1);
            this.Controls.Add(this.tienthoi1);
            this.Controls.Add(this.tienkhachdua1);
            this.Controls.Add(this.mahd1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tienthoi);
            this.Controls.Add(this.sodiem);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.tienkhachdua);
            this.Controls.Add(this.giora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ngaytao);
            this.Controls.Add(this.manv);
            this.Controls.Add(this.mahd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mahd;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Label ngaytao;
        private System.Windows.Forms.Label giora;
        private System.Windows.Forms.Label tienkhachdua;
        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.Label sodiem;
        private System.Windows.Forms.Label tienthoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mahd1;
        private System.Windows.Forms.TextBox manv1;
        private System.Windows.Forms.TextBox tongtien1;
        private System.Windows.Forms.TextBox tienkhachdua1;
        private System.Windows.Forms.TextBox tienthoi1;
        private System.Windows.Forms.TextBox sodiem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Suahd;
        private System.Windows.Forms.Button xoahd;
        private System.Windows.Forms.Button taohd;
        private System.Windows.Forms.DateTimePicker ngaytao1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker giovao1;
        private System.Windows.Forms.DateTimePicker giora1;
    }
}