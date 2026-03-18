namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmKhachHang
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtNguoiDaiDien = new TextBox();
            label5 = new Label();
            txtMaSoThue = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtTenCongTy = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            Idcol = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            MaSothue = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NguoiDaiDien = new DataGridViewTextBoxColumn();
            khachHangBindingSource = new BindingSource(components);
            khoiTaoMoiBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtNguoiDaiDien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaSoThue);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenCongTy);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(818, 148);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(425, 34);
            txtTimKiem.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(688, 148);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 26;
            label9.Text = "Tìm Kiếm: ";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(974, 212);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 46);
            btnNhap.TabIndex = 23;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(1122, 212);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 46);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(838, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 46);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Fuchsia;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(695, 212);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(111, 46);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(564, 212);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 46);
            btnHuyBo.TabIndex = 19;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Cyan;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(423, 212);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(284, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(148, 212);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(18, 212);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtNguoiDaiDien
            // 
            txtNguoiDaiDien.Location = new Point(818, 91);
            txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            txtNguoiDaiDien.Size = new Size(425, 34);
            txtNguoiDaiDien.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 91);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 8;
            label5.Text = "Người Đại Diện: ";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(818, 39);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(425, 34);
            txtMaSoThue.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(666, 39);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 6;
            label6.Text = "Mã Số Thuế: ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(148, 148);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(485, 34);
            txtDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 148);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Điện Thoại: ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(148, 94);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(485, 34);
            txtDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ: ";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(148, 42);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(485, 34);
            txtTenCongTy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Công Ty: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(818, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 448);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Khách Hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Idcol, TenCongTy, MaSothue, DiaChi, SoDienThoai, NguoiDaiDien });
            dgvKhachHang.DataSource = khachHangBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Location = new Point(6, 33);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvKhachHang.Size = new Size(1253, 409);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // Idcol
            // 
            Idcol.DataPropertyName = "ID";
            Idcol.FillWeight = 64.17112F;
            Idcol.HeaderText = "ID";
            Idcol.MinimumWidth = 6;
            Idcol.Name = "Idcol";
            // 
            // TenCongTy
            // 
            TenCongTy.DataPropertyName = "TenCongTy";
            TenCongTy.FillWeight = 107.165771F;
            TenCongTy.HeaderText = "Tên Công Ty";
            TenCongTy.MinimumWidth = 6;
            TenCongTy.Name = "TenCongTy";
            // 
            // MaSothue
            // 
            MaSothue.DataPropertyName = "MaSoThue";
            MaSothue.FillWeight = 107.165771F;
            MaSothue.HeaderText = "Mã Số Thuế";
            MaSothue.MinimumWidth = 6;
            MaSothue.Name = "MaSothue";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 107.165771F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.FillWeight = 107.165771F;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // NguoiDaiDien
            // 
            NguoiDaiDien.DataPropertyName = "NguoiDaiDien";
            NguoiDaiDien.FillWeight = 107.165771F;
            NguoiDaiDien.HeaderText = "Người Đại Diện";
            NguoiDaiDien.MinimumWidth = 6;
            NguoiDaiDien.Name = "NguoiDaiDien";
            // 
            // khachHangBindingSource
            // 
            khachHangBindingSource.DataSource = typeof(Data.KhachHang);
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHÁCH HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtNguoiDaiDien;
        private Label label5;
        private TextBox txtMaSoThue;
        private Label label6;
        private TextBox txtDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtTenCongTy;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvKhachHang;
        private BindingSource khachHangBindingSource;
        private BindingSource khoiTaoMoiBindingSource;
        private TextBox txtTimKiem;
        private Label label9;
        private DataGridViewTextBoxColumn Idcol;
        private DataGridViewTextBoxColumn TenCongTy;
        private DataGridViewTextBoxColumn MaSothue;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NguoiDaiDien;
        private PictureBox pictureBox1;
    }
}