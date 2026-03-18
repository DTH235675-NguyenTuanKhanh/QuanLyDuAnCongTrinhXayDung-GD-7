namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            label1 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(519, 86);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            label1.Click += label1_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 16.2F);
            txtTenDangNhap.Location = new Point(519, 122);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(320, 39);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextChanged += textBox1_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 16.2F);
            txtMatKhau.Location = new Point(519, 216);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(320, 39);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(519, 175);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.AutoSize = true;
            btnDangNhap.FlatStyle = FlatStyle.System;
            btnDangNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangNhap.Location = new Point(519, 261);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(149, 47);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.AutoSize = true;
            btnHuyBo.FlatStyle = FlatStyle.System;
            btnHuyBo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(688, 261);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(151, 47);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(861, 428);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnHuyBo;
    }
}