namespace _3.PL.View
{
    partial class FrmDoiEmail
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
            this.tb_EmailMoi = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_XacNhan = new _3.PL.Custom.AnButtons();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_EmailMoi
            // 
            this.tb_EmailMoi.Location = new System.Drawing.Point(174, 128);
            this.tb_EmailMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EmailMoi.Name = "tb_EmailMoi";
            this.tb_EmailMoi.Size = new System.Drawing.Size(386, 27);
            this.tb_EmailMoi.TabIndex = 9;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(174, 47);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(386, 27);
            this.tb_Email.TabIndex = 8;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_XacNhan.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_XacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XacNhan.BorderRadius = 20;
            this.btn_XacNhan.BorderSize = 0;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.ForeColor = System.Drawing.Color.Black;
            this.btn_XacNhan.Location = new System.Drawing.Point(389, 184);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(171, 53);
            this.btn_XacNhan.TabIndex = 7;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.TextColor = System.Drawing.Color.Black;
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // FrmDoiEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.tb_EmailMoi);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDoiEmail";
            this.Text = "FrmDoiEmail";
            this.Load += new System.EventHandler(this.FrmDoiEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EmailMoi;
        private System.Windows.Forms.TextBox tb_Email;
        private Custom.AnButtons btn_XacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}