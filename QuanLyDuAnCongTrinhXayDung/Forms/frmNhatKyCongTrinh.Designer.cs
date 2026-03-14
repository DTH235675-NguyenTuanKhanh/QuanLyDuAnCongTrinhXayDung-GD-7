namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmNhatKyCongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKyCongTrinh));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dtpNgayGhi = new DateTimePicker();
            cboDuAn = new ComboBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGhiChu = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtNoiDungCongViec = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            nhatKyCongTrinhBindingSource = new BindingSource(components);
            DuAn = new DataGridViewTextBoxColumn();
            NgayGhi = new DataGridViewTextBoxColumn();
            NoiDungCongViec = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhatKyCongTrinhBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtpNgayGhi);
            groupBox1.Controls.Add(cboDuAn);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNoiDungCongViec);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // dtpNgayGhi
            // 
            dtpNgayGhi.Location = new Point(148, 145);
            dtpNgayGhi.Name = "dtpNgayGhi";
            dtpNgayGhi.Size = new Size(250, 34);
            dtpNgayGhi.TabIndex = 25;
            // 
            // cboDuAn
            // 
            cboDuAn.FormattingEnabled = true;
            cboDuAn.Location = new Point(152, 42);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(481, 36);
            cboDuAn.TabIndex = 24;
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
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(759, 42);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(484, 34);
            txtGhiChu.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 42);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 8;
            label5.Text = "Ghi chú: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 144);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 6;
            label6.Text = "Ngày ghi: ";
            // 
            // txtNoiDungCongViec
            // 
            txtNoiDungCongViec.Location = new Point(208, 94);
            txtNoiDungCongViec.Name = "txtNoiDungCongViec";
            txtNoiDungCongViec.Size = new Size(1035, 34);
            txtNoiDungCongViec.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 2;
            label2.Text = "Nội dung công việc: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Dự Án: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 430);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhật ký";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { DuAn, NgayGhi, NoiDungCongViec, GhiChu });
            dataGridView.DataSource = nhatKyCongTrinhBindingSource;
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
            dataGridView.Size = new Size(1253, 382);
            dataGridView.TabIndex = 0;
            // 
            // nhatKyCongTrinhBindingSource
            // 
            nhatKyCongTrinhBindingSource.DataSource = typeof(Data.NhatKyCongTrinh);
            // 
            // DuAn
            // 
            DuAn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DuAn.DataPropertyName = "DuAn";
            DuAn.HeaderText = "Dự Án";
            DuAn.MinimumWidth = 6;
            DuAn.Name = "DuAn";
            DuAn.Width = 400;
            // 
            // NgayGhi
            // 
            NgayGhi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NgayGhi.DataPropertyName = "NgayGhi";
            NgayGhi.HeaderText = "Ngày Ghi";
            NgayGhi.MinimumWidth = 6;
            NgayGhi.Name = "NgayGhi";
            NgayGhi.Width = 200;
            // 
            // NoiDungCongViec
            // 
            NoiDungCongViec.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NoiDungCongViec.DataPropertyName = "NoiDungCongViec";
            NoiDungCongViec.HeaderText = "Nội Dung Công Việc";
            NoiDungCongViec.MinimumWidth = 6;
            NoiDungCongViec.Name = "NoiDungCongViec";
            NoiDungCongViec.Width = 500;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // frmNhatKyCongTrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 735);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhatKyCongTrinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật Ký Công Trình";
            WindowState = FormWindowState.Maximized;
            Load += frmNhatKyCongTrinh_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhatKyCongTrinhBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboDuAn;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtGhiChu;
        private Label label5;
        private Label label6;
        private TextBox txtNoiDungCongViec;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayGhi;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource nhatKyCongTrinhBindingSource;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn DuAn;
        private DataGridViewTextBoxColumn NgayGhi;
        private DataGridViewTextBoxColumn NoiDungCongViec;
        private DataGridViewTextBoxColumn GhiChu;
    }
}