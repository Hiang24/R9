namespace MyApp
{
    partial class frmCacl
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(140, 81);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(339, 81);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(532, 81);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(168, 29);
            this.txt_c.TabIndex = 2;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_c_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(140, 159);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(106, 23);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Phép toán cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Location = new System.Drawing.Point(140, 207);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(106, 23);
            this.btn_tru.TabIndex = 4;
            this.btn_tru.Text = "Phép toán trừ";
            this.btn_tru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(140, 255);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(106, 23);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Phép toán nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // frmCacl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Name = "frmCacl";
            this.Text = "frmCacl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btnNhan;
    }
}