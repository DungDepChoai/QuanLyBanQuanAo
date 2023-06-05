namespace _3.PL.View
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.cb_nmk = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new _3.PL.Custom.AnButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nmk
            // 
            this.cb_nmk.AutoSize = true;
            this.cb_nmk.Location = new System.Drawing.Point(24, 347);
            this.cb_nmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nmk.Name = "cb_nmk";
            this.cb_nmk.Size = new System.Drawing.Size(152, 24);
            this.cb_nmk.TabIndex = 24;
            this.cb_nmk.Text = "Ghi Nhớ Mật Khẩu";
            this.cb_nmk.UseVisualStyleBackColor = true;
            this.cb_nmk.CheckedChanged += new System.EventHandler(this.cb_nmk_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 10);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 179);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(3, 267);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 10);
            this.panel1.TabIndex = 19;
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.ForeColor = System.Drawing.Color.Black;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(63, 394);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(109, 20);
            this.lb_quenmatkhau.TabIndex = 18;
            this.lb_quenmatkhau.Text = "Quên mật khẩu";
            this.lb_quenmatkhau.Click += new System.EventHandler(this.lb_quenmatkhau_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.Color.White;
            this.tb_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_matkhau.Location = new System.Drawing.Point(101, 301);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.PlaceholderText = "PassWord";
            this.tb_matkhau.Size = new System.Drawing.Size(322, 20);
            this.tb_matkhau.TabIndex = 16;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.BackColor = System.Drawing.Color.White;
            this.tb_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taikhoan.ForeColor = System.Drawing.Color.Black;
            this.tb_taikhoan.Location = new System.Drawing.Point(101, 239);
            this.tb_taikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.PlaceholderText = "UserName";
            this.tb_taikhoan.Size = new System.Drawing.Size(322, 20);
            this.tb_taikhoan.TabIndex = 15;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_dangnhap.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangnhap.BorderRadius = 20;
            this.btn_dangnhap.BorderSize = 0;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Location = new System.Drawing.Point(380, 378);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(122, 53);
            this.btn_dangnhap.TabIndex = 25;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.TextColor = System.Drawing.Color.Black;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mật Khẩu";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(525, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.cb_nmk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_nmk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_quenmatkhau;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private Custom.AnButtons btn_dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}