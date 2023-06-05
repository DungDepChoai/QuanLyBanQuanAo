namespace _3.PL.View
{
    partial class FrmQuenMatKhau
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
            this.lb_loichao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nhaplai = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new _3.PL.Custom.AnButtons();
            this.SuspendLayout();
            // 
            // lb_loichao
            // 
            this.lb_loichao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loichao.Location = new System.Drawing.Point(664, 112);
            this.lb_loichao.Name = "lb_loichao";
            this.lb_loichao.Size = new System.Drawing.Size(470, 56);
            this.lb_loichao.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã";
            // 
            // tb_nhaplai
            // 
            this.tb_nhaplai.Location = new System.Drawing.Point(144, 218);
            this.tb_nhaplai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nhaplai.Name = "tb_nhaplai";
            this.tb_nhaplai.Size = new System.Drawing.Size(469, 27);
            this.tb_nhaplai.TabIndex = 16;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(144, 156);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(469, 27);
            this.tb_pass.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(144, 94);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(469, 27);
            this.tb_email.TabIndex = 14;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(144, 31);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(469, 27);
            this.tb_ma.TabIndex = 13;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_xacnhan.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_xacnhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xacnhan.BorderRadius = 20;
            this.btn_xacnhan.BorderSize = 0;
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.ForeColor = System.Drawing.Color.Black;
            this.btn_xacnhan.Location = new System.Drawing.Point(443, 290);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(171, 53);
            this.btn_xacnhan.TabIndex = 24;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.TextColor = System.Drawing.Color.Black;
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(682, 372);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.lb_loichao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nhaplai);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_ma);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_loichao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nhaplai;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_ma;
        private Custom.AnButtons btn_xacnhan;
    }
}