namespace LamViecVoiData
{
    partial class frmBan
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtLoaiB = new System.Windows.Forms.TextBox();
            this.txtSoBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.btnXoaMaKH = new System.Windows.Forms.Button();
            this.toolTipSoBan = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLoaiB = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMaKH = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 52);
            this.label4.TabIndex = 23;
            this.label4.Text = "QUẢN LÝ BÀN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(95, 495);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 38);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(315, 419);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 38);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(95, 419);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 38);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Tạo";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(315, 326);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(237, 30);
            this.txtMaKH.TabIndex = 19;
            this.txtMaKH.Click += new System.EventHandler(this.txtMaKH_Click);
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtMaKH.Enter += new System.EventHandler(this.txtMaKH_Enter);
            // 
            // txtLoaiB
            // 
            this.txtLoaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiB.Location = new System.Drawing.Point(468, 251);
            this.txtLoaiB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiB.Name = "txtLoaiB";
            this.txtLoaiB.Size = new System.Drawing.Size(84, 30);
            this.txtLoaiB.TabIndex = 18;
            this.txtLoaiB.Click += new System.EventHandler(this.txtLoaiB_Click);
            this.txtLoaiB.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            this.txtLoaiB.Enter += new System.EventHandler(this.txtLoaiB_Enter);
            // 
            // txtSoBan
            // 
            this.txtSoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBan.Location = new System.Drawing.Point(172, 251);
            this.txtSoBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(161, 30);
            this.txtSoBan.TabIndex = 17;
            this.toolTipSoBan.SetToolTip(this.txtSoBan, "Hãy nhập theo cú pháp B + số bàn  và tối đa 6 kí tự ( ví dụ: B00001)");
            this.txtSoBan.Click += new System.EventHandler(this.txtSoBan_Click);
            this.txtSoBan.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            this.txtSoBan.Enter += new System.EventHandler(this.txtSoBan_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã khách hàng dùng bàn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Loại bàn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã số bàn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LamViecVoiData.Properties.Resources.CK;
            this.pbLogo.Location = new System.Drawing.Point(33, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(179, 96);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(612, 46);
            this.dataGridViewBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.Size = new System.Drawing.Size(368, 521);
            this.dataGridViewBan.TabIndex = 24;
            this.dataGridViewBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnXoaMaKH
            // 
            this.btnXoaMaKH.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoaMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMaKH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaMaKH.Location = new System.Drawing.Point(315, 495);
            this.btnXoaMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMaKH.Name = "btnXoaMaKH";
            this.btnXoaMaKH.Size = new System.Drawing.Size(138, 38);
            this.btnXoaMaKH.TabIndex = 25;
            this.btnXoaMaKH.Text = "Xóa khách hàng";
            this.btnXoaMaKH.UseVisualStyleBackColor = false;
            this.btnXoaMaKH.Click += new System.EventHandler(this.btnXoaMaKH_Click);
            // 
            // toolTipSoBan
            // 
            this.toolTipSoBan.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipSoBan.ToolTipTitle = "Lưu ý";
            // 
            // toolTipLoaiB
            // 
            this.toolTipLoaiB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipLoaiB.ToolTipTitle = "Lưu ý:";
            // 
            // toolTipMaKH
            // 
            this.toolTipMaKH.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipMaKH.ToolTipTitle = "Lưu ý:";
            // 
            // frmBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1009, 616);
            this.Controls.Add(this.btnXoaMaKH);
            this.Controls.Add(this.dataGridViewBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtLoaiB);
            this.Controls.Add(this.txtSoBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Bàn";
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtLoaiB;
        private System.Windows.Forms.TextBox txtSoBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.Button btnXoaMaKH;
        private System.Windows.Forms.ToolTip toolTipSoBan;
        private System.Windows.Forms.ToolTip toolTipLoaiB;
        private System.Windows.Forms.ToolTip toolTipMaKH;
    }
}