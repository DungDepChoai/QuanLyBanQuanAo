﻿namespace _3.PL.View
{
    partial class FrmKhachHang
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
            this.btn_tk = new _3.PL.Custom.AnButtons();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.Dgrid_KH = new System.Windows.Forms.DataGridView();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_Cmnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tendem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_thanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_quocGia = new System.Windows.Forms.TextBox();
            this.cbx_HD = new System.Windows.Forms.RadioButton();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.cbx_NHD = new System.Windows.Forms.RadioButton();
            this.date_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.anButtons2 = new _3.PL.Custom.AnButtons();
            this.btn_Them = new _3.PL.Custom.AnButtons();
            this.anButtons3 = new _3.PL.Custom.AnButtons();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.anButtons1 = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tk
            // 
            this.btn_tk.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_tk.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_tk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_tk.BorderRadius = 20;
            this.btn_tk.BorderSize = 0;
            this.btn_tk.FlatAppearance.BorderSize = 0;
            this.btn_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tk.ForeColor = System.Drawing.Color.Black;
            this.btn_tk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tk.Location = new System.Drawing.Point(488, 385);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(181, 33);
            this.btn_tk.TabIndex = 50;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.TextColor = System.Drawing.Color.Black;
            this.btn_tk.UseVisualStyleBackColor = false;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(103, 385);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(366, 27);
            this.txt_TK.TabIndex = 41;
            // 
            // Dgrid_KH
            // 
            this.Dgrid_KH.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Dgrid_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_KH.Location = new System.Drawing.Point(25, 424);
            this.Dgrid_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgrid_KH.Name = "Dgrid_KH";
            this.Dgrid_KH.RowHeadersWidth = 51;
            this.Dgrid_KH.RowTemplate.Height = 25;
            this.Dgrid_KH.Size = new System.Drawing.Size(1161, 157);
            this.Dgrid_KH.TabIndex = 42;
            this.Dgrid_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_KH_CellClick);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(323, 139);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(138, 27);
            this.txt_sdt.TabIndex = 9;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            this.txt_sdt.Leave += new System.EventHandler(this.txt_sdt_Leave);
            // 
            // txt_Cmnd
            // 
            this.txt_Cmnd.Location = new System.Drawing.Point(323, 88);
            this.txt_Cmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Cmnd.Name = "txt_Cmnd";
            this.txt_Cmnd.Size = new System.Drawing.Size(138, 27);
            this.txt_Cmnd.TabIndex = 13;
            this.txt_Cmnd.TextChanged += new System.EventHandler(this.txt_Cmnd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Giới tính";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(78, 160);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(114, 27);
            this.txt_ten.TabIndex = 5;
            this.txt_ten.Click += new System.EventHandler(this.txt_ten_TextChanged);
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên";
            // 
            // txt_Tendem
            // 
            this.txt_Tendem.Location = new System.Drawing.Point(78, 120);
            this.txt_Tendem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tendem.Name = "txt_Tendem";
            this.txt_Tendem.Size = new System.Drawing.Size(114, 27);
            this.txt_Tendem.TabIndex = 4;
            this.txt_Tendem.Click += new System.EventHandler(this.txt_Tendem_TextChanged);
            this.txt_Tendem.Leave += new System.EventHandler(this.txt_Tendem_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên đệm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "SDT";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(627, 41);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(114, 27);
            this.txt_diaChi.TabIndex = 11;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(78, 75);
            this.txt_Ho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(114, 27);
            this.txt_Ho.TabIndex = 3;
            this.txt_Ho.Click += new System.EventHandler(this.txt_Ho_TextChanged);
            this.txt_Ho.Leave += new System.EventHandler(this.txt_Ho_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Trạng thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(522, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Địa chỉ";
            // 
            // txt_thanhPho
            // 
            this.txt_thanhPho.Location = new System.Drawing.Point(627, 95);
            this.txt_thanhPho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thanhPho.Name = "txt_thanhPho";
            this.txt_thanhPho.Size = new System.Drawing.Size(114, 27);
            this.txt_thanhPho.TabIndex = 10;
            this.txt_thanhPho.TextChanged += new System.EventHandler(this.txt_thanhPho_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_nu);
            this.panel1.Controls.Add(this.rbtn_Nam);
            this.panel1.Location = new System.Drawing.Point(320, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 44);
            this.panel1.TabIndex = 40;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(3, 9);
            this.rbtn_Nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rbtn_Nam.TabIndex = 41;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Location = new System.Drawing.Point(88, 8);
            this.rbtn_nu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(50, 24);
            this.rbtn_nu.TabIndex = 41;
            this.rbtn_nu.TabStop = true;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_ngaySinh);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbx_NHD);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.cbx_HD);
            this.groupBox1.Controls.Add(this.txt_quocGia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_thanhPho);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_Ho);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Tendem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Cmnd);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 341);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ngày sinh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Thành phố";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(522, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Quốc gia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Tìm kiếm";
            // 
            // txt_quocGia
            // 
            this.txt_quocGia.Location = new System.Drawing.Point(627, 145);
            this.txt_quocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_quocGia.Name = "txt_quocGia";
            this.txt_quocGia.Size = new System.Drawing.Size(114, 27);
            this.txt_quocGia.TabIndex = 8;
            this.txt_quocGia.Text = "Việt Nam";
            // 
            // cbx_HD
            // 
            this.cbx_HD.AutoSize = true;
            this.cbx_HD.Location = new System.Drawing.Point(105, 273);
            this.cbx_HD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_HD.Name = "cbx_HD";
            this.cbx_HD.Size = new System.Drawing.Size(102, 24);
            this.cbx_HD.TabIndex = 38;
            this.cbx_HD.TabStop = true;
            this.cbx_HD.Text = "Hoạt động";
            this.cbx_HD.UseVisualStyleBackColor = true;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(78, 35);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(114, 27);
            this.txt_Ma.TabIndex = 2;
            // 
            // cbx_NHD
            // 
            this.cbx_NHD.AutoSize = true;
            this.cbx_NHD.Location = new System.Drawing.Point(209, 276);
            this.cbx_NHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_NHD.Name = "cbx_NHD";
            this.cbx_NHD.Size = new System.Drawing.Size(149, 24);
            this.cbx_NHD.TabIndex = 39;
            this.cbx_NHD.TabStop = true;
            this.cbx_NHD.Text = "Ngừng hoạt động";
            this.cbx_NHD.UseVisualStyleBackColor = true;
            // 
            // date_ngaySinh
            // 
            this.date_ngaySinh.Location = new System.Drawing.Point(102, 216);
            this.date_ngaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ngaySinh.Name = "date_ngaySinh";
            this.date_ngaySinh.Size = new System.Drawing.Size(273, 27);
            this.date_ngaySinh.TabIndex = 35;
            // 
            // anButtons2
            // 
            this.anButtons2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons2.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons2.BorderRadius = 20;
            this.anButtons2.BorderSize = 0;
            this.anButtons2.FlatAppearance.BorderSize = 0;
            this.anButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons2.ForeColor = System.Drawing.Color.Black;
            this.anButtons2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anButtons2.Location = new System.Drawing.Point(23, 193);
            this.anButtons2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.anButtons2.Name = "anButtons2";
            this.anButtons2.Size = new System.Drawing.Size(202, 53);
            this.anButtons2.TabIndex = 48;
            this.anButtons2.Text = "Xóa";
            this.anButtons2.TextColor = System.Drawing.Color.Black;
            this.anButtons2.UseVisualStyleBackColor = false;
            this.anButtons2.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(23, 33);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(202, 53);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // anButtons3
            // 
            this.anButtons3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons3.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons3.BorderRadius = 20;
            this.anButtons3.BorderSize = 0;
            this.anButtons3.FlatAppearance.BorderSize = 0;
            this.anButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons3.ForeColor = System.Drawing.Color.Black;
            this.anButtons3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anButtons3.Location = new System.Drawing.Point(23, 273);
            this.anButtons3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.anButtons3.Name = "anButtons3";
            this.anButtons3.Size = new System.Drawing.Size(202, 53);
            this.anButtons3.TabIndex = 49;
            this.anButtons3.Text = "Reset";
            this.anButtons3.TextColor = System.Drawing.Color.Black;
            this.anButtons3.UseVisualStyleBackColor = false;
            this.anButtons3.Click += new System.EventHandler(this.btn_CLEAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.anButtons3);
            this.groupBox2.Controls.Add(this.anButtons1);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.anButtons2);
            this.groupBox2.Location = new System.Drawing.Point(935, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 341);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // anButtons1
            // 
            this.anButtons1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons1.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.anButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons1.BorderRadius = 20;
            this.anButtons1.BorderSize = 0;
            this.anButtons1.FlatAppearance.BorderSize = 0;
            this.anButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons1.ForeColor = System.Drawing.Color.Black;
            this.anButtons1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anButtons1.Location = new System.Drawing.Point(23, 109);
            this.anButtons1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.anButtons1.Name = "anButtons1";
            this.anButtons1.Size = new System.Drawing.Size(202, 53);
            this.anButtons1.TabIndex = 47;
            this.anButtons1.Text = "Sửa";
            this.anButtons1.TextColor = System.Drawing.Color.Black;
            this.anButtons1.UseVisualStyleBackColor = false;
            this.anButtons1.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgrid_KH);
            this.Controls.Add(this.txt_TK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.AnButtons btn_tk;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.DataGridView Dgrid_KH;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_Cmnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tendem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_thanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_ngaySinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton cbx_NHD;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.RadioButton cbx_HD;
        private System.Windows.Forms.TextBox txt_quocGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private Custom.AnButtons anButtons2;
        private Custom.AnButtons btn_Them;
        private Custom.AnButtons anButtons3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Custom.AnButtons anButtons1;
    }
}