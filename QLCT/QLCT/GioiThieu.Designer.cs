namespace QLCT
{
    partial class GioiThieu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonDangKi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng đến với ứng dụng Quản Lí Chi Tiêu Dự Định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vui lòng đăng nhập để sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(328, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quản lí tài chính, ổn định tương lai :3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hoặc đăng kí nếu chưa có tài khoản";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDangNhap.Location = new System.Drawing.Point(651, 259);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(205, 53);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonDangKi
            // 
            this.buttonDangKi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDangKi.Location = new System.Drawing.Point(651, 349);
            this.buttonDangKi.Name = "buttonDangKi";
            this.buttonDangKi.Size = new System.Drawing.Size(205, 54);
            this.buttonDangKi.TabIndex = 5;
            this.buttonDangKi.Text = "Đăng kí";
            this.buttonDangKi.UseVisualStyleBackColor = false;
            this.buttonDangKi.Click += new System.EventHandler(this.buttonDangKi_Click);
            // 
            // GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1018, 525);
            this.Controls.Add(this.buttonDangKi);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "GioiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới Thiệu";
            this.Load += new System.EventHandler(this.GioiThieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonDangKi;
    }
}