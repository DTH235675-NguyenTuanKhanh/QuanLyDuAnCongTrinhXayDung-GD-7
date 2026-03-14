namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmDuAn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuAn));
            groupBox1 = new GroupBox();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            cboNhaDauTu = new ComboBox();
            cboKhachHang = new ComboBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTenLoai = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNganSach = new TextBox();
            label3 = new Label();
            txtDiaDiem = new TextBox();
            label2 = new Label();
            txtTenDuAn = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenDuAn = new DataGridViewTextBoxColumn();
            colLoaiDuAn = new DataGridViewTextBoxColumn();
            colNhaDauTu = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            DiaDiem = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            NganSach = new DataGridViewTextBoxColumn();
            duAnBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duAnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(cboNhaDauTu);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboTenLoai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNganSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaDiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenDuAn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1317, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Dự án";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Location = new Point(1021, 145);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(256, 34);
            dtpNgayKetThuc.TabIndex = 29;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(1017, 90);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(260, 34);
            dtpNgayBatDau.TabIndex = 28;
            // 
            // cboNhaDauTu
            // 
            cboNhaDauTu.FormattingEnabled = true;
            cboNhaDauTu.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboNhaDauTu.Location = new Point(564, 93);
            cboNhaDauTu.Name = "cboNhaDauTu";
            cboNhaDauTu.Size = new Size(301, 36);
            cboNhaDauTu.TabIndex = 27;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboKhachHang.Location = new Point(564, 42);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(301, 36);
            cboKhachHang.TabIndex = 26;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(996, 206);
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
            btnXuat.Location = new Point(1144, 206);
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
            btnThoat.Location = new Point(860, 206);
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
            btnTimKiem.Location = new Point(717, 206);
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
            btnHuyBo.Location = new Point(586, 206);
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
            btnLuu.Location = new Point(445, 206);
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
            btnXoa.Location = new Point(306, 206);
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
            btnSua.Location = new Point(170, 206);
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
            btnThem.Location = new Point(40, 206);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboTenLoai
            // 
            cboTenLoai.FormattingEnabled = true;
            cboTenLoai.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboTenLoai.Location = new Point(122, 93);
            cboTenLoai.Name = "cboTenLoai";
            cboTenLoai.Size = new Size(316, 36);
            cboTenLoai.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(880, 90);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 14;
            label7.Text = "Ngày bắt đầu: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(880, 145);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 12;
            label8.Text = "Ngày kết thúc: ";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 96);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 10;
            label4.Text = "Nhà đầu tư: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 42);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 8;
            label5.Text = "Khách hàng: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 96);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 6;
            label6.Text = "Loại dự án: ";
            // 
            // txtNganSach
            // 
            txtNganSach.Location = new Point(985, 44);
            txtNganSach.Name = "txtNganSach";
            txtNganSach.Size = new Size(292, 34);
            txtNganSach.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(876, 44);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 4;
            label3.Text = "Ngân sách: ";
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Location = new Point(122, 151);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(743, 34);
            txtDiaDiem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 151);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa điểm: ";
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(122, 39);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(316, 34);
            txtTenDuAn.TabIndex = 1;
            txtTenDuAn.TextChanged += txtHoTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên dự án: ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1317, 510);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Dự án";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenDuAn, colLoaiDuAn, colNhaDauTu, colKhachHang, DiaDiem, NgayBatDau, NgayKetThuc, NganSach });
            dataGridView.DataSource = duAnBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1305, 471);
            dataGridView.TabIndex = 0;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 50;
            // 
            // TenDuAn
            // 
            TenDuAn.DataPropertyName = "TenDuAn";
            TenDuAn.HeaderText = "Tên dự án";
            TenDuAn.MinimumWidth = 6;
            TenDuAn.Name = "TenDuAn";
            // 
            // colLoaiDuAn
            // 
            colLoaiDuAn.DataPropertyName = "TenLoai";
            colLoaiDuAn.HeaderText = "Loại dự án";
            colLoaiDuAn.MinimumWidth = 6;
            colLoaiDuAn.Name = "colLoaiDuAn";
            // 
            // colNhaDauTu
            // 
            colNhaDauTu.DataPropertyName = "TenNhaDauTu";
            colNhaDauTu.HeaderText = "Nhà đầu tư";
            colNhaDauTu.MinimumWidth = 6;
            colNhaDauTu.Name = "colNhaDauTu";
            // 
            // colKhachHang
            // 
            colKhachHang.DataPropertyName = "TenKhachHang";
            colKhachHang.HeaderText = "Khách hàng";
            colKhachHang.MinimumWidth = 6;
            colKhachHang.Name = "colKhachHang";
            // 
            // DiaDiem
            // 
            DiaDiem.DataPropertyName = "DiaDiem";
            DiaDiem.HeaderText = "Địa diểm";
            DiaDiem.MinimumWidth = 6;
            DiaDiem.Name = "DiaDiem";
            // 
            // NgayBatDau
            // 
            NgayBatDau.DataPropertyName = "NgayBatDau";
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            // 
            // NganSach
            // 
            NganSach.DataPropertyName = "NganSach";
            NganSach.HeaderText = "Ngân sách";
            NganSach.MinimumWidth = 6;
            NganSach.Name = "NganSach";
            // 
            // duAnBindingSource
            // 
            duAnBindingSource.DataSource = typeof(Data.DuAn);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(909, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // frmDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 822);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dự Án";
            WindowState = FormWindowState.Maximized;
            Load += frmDuAn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)duAnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ComboBox cboTenLoai;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNganSach;
        private Label label3;
        private TextBox txtDiaDiem;
        private Label label2;
        private TextBox txtTenDuAn;
        private Label label1;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cboNhaDauTu;
        private ComboBox cboKhachHang;
        private DateTimePicker dtpNgayKetThuc;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource duAnBindingSource;
        private DataGridViewTextBoxColumn LoaiDuAn;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhaDauTu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenDuAn;
        private DataGridViewTextBoxColumn colLoaiDuAn;
        private DataGridViewTextBoxColumn colNhaDauTu;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn DiaDiem;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn NganSach;
        private PictureBox pictureBox1;
    }
}