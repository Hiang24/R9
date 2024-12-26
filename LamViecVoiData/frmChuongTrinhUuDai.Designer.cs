namespace LamViecVoiData
{
    partial class frmChuongTrinhUuDai
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
            this.components = new System.ComponentModel.Container();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaUD = new System.Windows.Forms.TextBox();
            this.txtThongTinUD = new System.Windows.Forms.TextBox();
            this.txtTenUD = new System.Windows.Forms.TextBox();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCTUD = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolTipMaUD = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTUD)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LamViecVoiData.Properties.Resources.CK;
            this.pbLogo.Location = new System.Drawing.Point(33, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(179, 96);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên chương trình ưu đãi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin ưu đãi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã ưu đãi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày kết thúc:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày bắt đầu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(597, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "QUẢN LÝ CHƯƠNG TRÌNH ƯU ĐÃI";
            // 
            // txtMaUD
            // 
            this.txtMaUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaUD.Location = new System.Drawing.Point(257, 157);
            this.txtMaUD.Name = "txtMaUD";
            this.txtMaUD.Size = new System.Drawing.Size(358, 26);
            this.txtMaUD.TabIndex = 23;
            this.txtMaUD.Enter += new System.EventHandler(this.txtMaUD_Enter);
            // 
            // txtThongTinUD
            // 
            this.txtThongTinUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinUD.Location = new System.Drawing.Point(257, 187);
            this.txtThongTinUD.Multiline = true;
            this.txtThongTinUD.Name = "txtThongTinUD";
            this.txtThongTinUD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtThongTinUD.Size = new System.Drawing.Size(358, 56);
            this.txtThongTinUD.TabIndex = 24;
            // 
            // txtTenUD
            // 
            this.txtTenUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenUD.Location = new System.Drawing.Point(257, 249);
            this.txtTenUD.Name = "txtTenUD";
            this.txtTenUD.Size = new System.Drawing.Size(358, 26);
            this.txtTenUD.TabIndex = 25;
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.CustomFormat = "yyyy-MM-dd";
            this.dtNgayBD.Location = new System.Drawing.Point(257, 282);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(358, 20);
            this.dtNgayBD.TabIndex = 26;
            this.dtNgayBD.Value = new System.DateTime(2024, 12, 25, 23, 15, 57, 0);
            this.dtNgayBD.ValueChanged += new System.EventHandler(this.dtNgayBD_ValueChanged);
            this.dtNgayBD.Enter += new System.EventHandler(this.dtNgayBD_Enter);
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT.CustomFormat = "yyyy-MM-dd";
            this.dtNgayKT.Location = new System.Drawing.Point(257, 310);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(358, 20);
            this.dtNgayKT.TabIndex = 27;
            // 
            // dataGridViewCTUD
            // 
            this.dataGridViewCTUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCTUD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTUD.Location = new System.Drawing.Point(141, 352);
            this.dataGridViewCTUD.Name = "dataGridViewCTUD";
            this.dataGridViewCTUD.RowHeadersWidth = 51;
            this.dataGridViewCTUD.RowTemplate.Height = 24;
            this.dataGridViewCTUD.Size = new System.Drawing.Size(633, 306);
            this.dataGridViewCTUD.TabIndex = 28;
            this.dataGridViewCTUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTUD_CellClick);
            this.dataGridViewCTUD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTUD_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(679, 157);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 38);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Tạo";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(679, 215);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 38);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(679, 270);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 38);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolTipMaUD
            // 
            this.toolTipMaUD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipMaUD.ToolTipTitle = "Lưu ý:";
            // 
            // frmChuongTrinhUuDai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(918, 670);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewCTUD);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.txtTenUD);
            this.Controls.Add(this.txtThongTinUD);
            this.Controls.Add(this.txtMaUD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmChuongTrinhUuDai";
            this.Text = "QUẢN LÝ CHƯƠNG TRÌNH ƯU ĐÃI";
            this.Load += new System.EventHandler(this.frmChuongTrinhUuDai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaUD;
        private System.Windows.Forms.TextBox txtThongTinUD;
        private System.Windows.Forms.TextBox txtTenUD;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.DataGridView dataGridViewCTUD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ToolTip toolTipMaUD;
    }
}