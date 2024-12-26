namespace ChickenPlus
{
    partial class frmMonAn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaMA = new System.Windows.Forms.TextBox();
            this.TenMA = new System.Windows.Forms.TextBox();
            this.DonGia = new System.Windows.Forms.TextBox();
            this.TaoMA = new System.Windows.Forms.Button();
            this.SuaMA = new System.Windows.Forms.Button();
            this.XoaMA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(569, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(373, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU MÓN ĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // MaMA
            // 
            this.MaMA.Location = new System.Drawing.Point(288, 213);
            this.MaMA.Name = "MaMA";
            this.MaMA.Size = new System.Drawing.Size(138, 22);
            this.MaMA.TabIndex = 0;
            // 
            // TenMA
            // 
            this.TenMA.Location = new System.Drawing.Point(288, 278);
            this.TenMA.Name = "TenMA";
            this.TenMA.Size = new System.Drawing.Size(138, 22);
            this.TenMA.TabIndex = 1;
            // 
            // DonGia
            // 
            this.DonGia.Location = new System.Drawing.Point(288, 349);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(138, 22);
            this.DonGia.TabIndex = 2;
            // 
            // TaoMA
            // 
            this.TaoMA.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaoMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaoMA.Location = new System.Drawing.Point(95, 431);
            this.TaoMA.Name = "TaoMA";
            this.TaoMA.Size = new System.Drawing.Size(88, 36);
            this.TaoMA.TabIndex = 3;
            this.TaoMA.Text = "Tạo";
            this.TaoMA.UseVisualStyleBackColor = false;
            this.TaoMA.Click += new System.EventHandler(this.TaoMA_Click);
            // 
            // SuaMA
            // 
            this.SuaMA.BackColor = System.Drawing.Color.Gainsboro;
            this.SuaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaMA.Location = new System.Drawing.Point(227, 431);
            this.SuaMA.Name = "SuaMA";
            this.SuaMA.Size = new System.Drawing.Size(81, 36);
            this.SuaMA.TabIndex = 4;
            this.SuaMA.Text = "Sửa";
            this.SuaMA.UseVisualStyleBackColor = false;
            this.SuaMA.Click += new System.EventHandler(this.SuaMA_Click);
            // 
            // XoaMA
            // 
            this.XoaMA.BackColor = System.Drawing.Color.Firebrick;
            this.XoaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaMA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XoaMA.Location = new System.Drawing.Point(352, 431);
            this.XoaMA.Name = "XoaMA";
            this.XoaMA.Size = new System.Drawing.Size(84, 36);
            this.XoaMA.TabIndex = 5;
            this.XoaMA.Text = "Xóa";
            this.XoaMA.UseVisualStyleBackColor = false;
            this.XoaMA.Click += new System.EventHandler(this.XoaMA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LamViecVoiData.Properties.Resources.CK;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMonAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1009, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XoaMA);
            this.Controls.Add(this.SuaMA);
            this.Controls.Add(this.TaoMA);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.TenMA);
            this.Controls.Add(this.MaMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Món Ăn";
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaMA;
        private System.Windows.Forms.TextBox TenMA;
        private System.Windows.Forms.TextBox DonGia;
        private System.Windows.Forms.Button TaoMA;
        private System.Windows.Forms.Button SuaMA;
        private System.Windows.Forms.Button XoaMA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}