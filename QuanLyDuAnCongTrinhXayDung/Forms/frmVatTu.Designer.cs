namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmVatTu
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
            groupBox1 = new GroupBox();
            numDonGia = new NumericUpDown();
            btnDoiAnh = new Button();
            label4 = new Label();
            ptbHinhAnh = new PictureBox();
            txtTenVatTu = new TextBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDonViTinh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenVatTu = new DataGridViewTextBoxColumn();
            colDonViTinh = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            danhSachVatTuBindingSource = new BindingSource(components);
            vatTuBindingSource = new BindingSource(components);
            phanPhoiChiTietBindingSource = new BindingSource(components);
            phanPhoiBindingSource = new BindingSource(components);
            chiTietPhanPhoiBindingSource = new BindingSource(components);
            phanPhoiBindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachVatTuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatTuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietPhanPhoiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ptbHinhAnh);
            groupBox1.Controls.Add(txtTenVatTu);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 275);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Vật tư";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(132, 89);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(356, 34);
            numDonGia.TabIndex = 37;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.Fuchsia;
            btnDoiAnh.ForeColor = Color.Black;
            btnDoiAnh.Location = new Point(531, 108);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(110, 46);
            btnDoiAnh.TabIndex = 36;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 39);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 35;
            label4.Text = "Hình ảnh: ";
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Location = new Point(659, 39);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(165, 140);
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHinhAnh.TabIndex = 34;
            ptbHinhAnh.TabStop = false;
            // 
            // txtTenVatTu
            // 
            txtTenVatTu.Location = new Point(132, 39);
            txtTenVatTu.Name = "txtTenVatTu";
            txtTenVatTu.Size = new Size(356, 34);
            txtTenVatTu.TabIndex = 33;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(1035, 145);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(128, 46);
            btnNhap.TabIndex = 23;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(867, 145);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 46);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(1035, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Fuchsia;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(860, 212);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 46);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(695, 212);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 46);
            btnHuyBo.TabIndex = 19;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Cyan;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(531, 212);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(366, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(206, 212);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(43, 212);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(132, 145);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(356, 34);
            txtDonViTinh.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 4;
            label3.Text = "Đơn vị tính: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Vật tư: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1179, 421);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Lương";
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colTenVatTu, colDonViTinh, colDonGia, HinhAnh });
            dataGridView.DataSource = danhSachVatTuBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1167, 382);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.Frozen = true;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 223;
            // 
            // colTenVatTu
            // 
            colTenVatTu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTenVatTu.DataPropertyName = "TenVatTu";
            colTenVatTu.Frozen = true;
            colTenVatTu.HeaderText = "Tên Vật tư";
            colTenVatTu.MinimumWidth = 6;
            colTenVatTu.Name = "colTenVatTu";
            colTenVatTu.Width = 223;
            // 
            // colDonViTinh
            // 
            colDonViTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDonViTinh.DataPropertyName = "DonViTinh";
            colDonViTinh.Frozen = true;
            colDonViTinh.HeaderText = "Đơn Vị Tính";
            colDonViTinh.MinimumWidth = 6;
            colDonViTinh.Name = "colDonViTinh";
            colDonViTinh.Width = 222;
            // 
            // colDonGia
            // 
            colDonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.Frozen = true;
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.Width = 223;
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.Frozen = true;
            HinhAnh.HeaderText = "HinhAnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Width = 223;
            // 
            // danhSachVatTuBindingSource
            // 
            danhSachVatTuBindingSource.DataSource = typeof(Data.DanhSachVatTu);
            // 
            // vatTuBindingSource
            // 
            vatTuBindingSource.DataSource = typeof(Data.VatTu);
            // 
            // phanPhoiChiTietBindingSource
            // 
            phanPhoiChiTietBindingSource.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // phanPhoiBindingSource
            // 
            phanPhoiBindingSource.DataSource = typeof(Data.PhanPhoi);
            // 
            // chiTietPhanPhoiBindingSource
            // 
            chiTietPhanPhoiBindingSource.DataMember = "ChiTietPhanPhoi";
            chiTietPhanPhoiBindingSource.DataSource = phanPhoiBindingSource;
            // 
            // phanPhoiBindingSource1
            // 
            phanPhoiBindingSource1.DataSource = typeof(Data.PhanPhoi);
            // 
            // frmVatTu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 774);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVatTu";
            Text = "Vật Tư";
            Load += frmVatTu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachVatTuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatTuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietPhanPhoiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource1).EndInit();
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
        private TextBox txtDonViTinh;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenVatTu;
        private Button btnDoiAnh;
        private Label label4;
        private PictureBox ptbHinhAnh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource chiTietPhanPhoiBindingSource;
        private BindingSource phanPhoiBindingSource;
        private BindingSource phanPhoiChiTietBindingSource;
        private BindingSource vatTuBindingSource;
        private BindingSource phanPhoiBindingSource1;
        private NumericUpDown numDonGia;
        private BindingSource danhSachVatTuBindingSource;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenVatTu;
        private DataGridViewTextBoxColumn colDonViTinh;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}