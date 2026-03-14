namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmLoaiDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDuAn));
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoaiDuAn = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            loaiDuAnBindingSource = new BindingSource(components);
            vatTuChiTietBindingSource = new BindingSource(components);
            khoiTaoMoiBindingSource = new BindingSource(components);
            khoiTaoBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDuAnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatTuChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoaiDuAn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1261, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dự án";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(975, 88);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 46);
            btnNhap.TabIndex = 32;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(841, 88);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 46);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(1123, 88);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(121, 46);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Fuchsia;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(698, 88);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(111, 46);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(567, 88);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 46);
            btnHuyBo.TabIndex = 28;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Cyan;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(426, 88);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 46);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(287, 88);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 46);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(151, 88);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 46);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(21, 88);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoaiDuAn
            // 
            txtTenLoaiDuAn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenLoaiDuAn.Location = new Point(200, 34);
            txtTenLoaiDuAn.Name = "txtTenLoaiDuAn";
            txtTenLoaiDuAn.Size = new Size(1044, 30);
            txtTenLoaiDuAn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(21, 42);
            label2.Name = "label2";
            label2.Size = new Size(173, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên Loại Dự Án(*): ";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1261, 339);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, TenLoai });
            dataGridView.DataSource = loaiDuAnBindingSource;
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
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1249, 299);
            dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "ID";
            Id.FillWeight = 53.4759369F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 146.524063F;
            TenLoai.HeaderText = "Tên Loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // loaiDuAnBindingSource
            // 
            loaiDuAnBindingSource.DataSource = typeof(Data.LoaiDuAn);
            // 
            // khoiTaoBindingSource
            // 
            khoiTaoBindingSource.DataSource = typeof(Migrations.KhoiTao);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(940, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // frmLoaiDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 566);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiDuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Dự Án";
            WindowState = FormWindowState.Maximized;
            Load += frmLoaiDuAn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDuAnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatTuChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtTenLoaiDuAn;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private BindingSource vatTuChiTietBindingSource;
        private BindingSource khoiTaoMoiBindingSource;
        private DataGridView dataGridView;
        private BindingSource loaiDuAnBindingSource;
        private BindingSource khoiTaoBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TenLoai;
        private PictureBox pictureBox1;
    }
}