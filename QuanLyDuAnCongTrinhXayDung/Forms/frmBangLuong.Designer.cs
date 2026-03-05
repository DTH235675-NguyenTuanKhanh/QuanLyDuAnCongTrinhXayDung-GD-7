namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmBangLuong
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
            groupBox1 = new GroupBox();
            txtLuongCoBan = new TextBox();
            label7 = new Label();
            cboNhanVien = new ComboBox();
            txtSoNgayCong = new TextBox();
            label4 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtThucLinh = new TextBox();
            label5 = new Label();
            txtTongPhuCap = new TextBox();
            label6 = new Label();
            txtNam = new TextBox();
            label3 = new Label();
            txtThang = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            ThucLinh = new DataGridViewTextBoxColumn();
            bangLuongBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bangLuongBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(txtSoNgayCong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtThucLinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTongPhuCap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtThang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Lương";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(839, 91);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(325, 34);
            txtLuongCoBan.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(687, 91);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 31;
            label7.Text = "Lương Cơ Bản: ";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(169, 38);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(491, 36);
            cboNhanVien.TabIndex = 30;
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Location = new Point(468, 91);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(192, 34);
            txtSoNgayCong.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 91);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 28;
            label4.Text = "Số ngày công: ";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(863, 148);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(128, 46);
            btnNhap.TabIndex = 23;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(695, 148);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 46);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
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
            // txtThucLinh
            // 
            txtThucLinh.Location = new Point(818, 46);
            txtThucLinh.Name = "txtThucLinh";
            txtThucLinh.Size = new Size(346, 34);
            txtThucLinh.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 46);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 8;
            label5.Text = "Thực Lĩnh: ";
            // 
            // txtTongPhuCap
            // 
            txtTongPhuCap.Location = new Point(468, 148);
            txtTongPhuCap.Name = "txtTongPhuCap";
            txtTongPhuCap.Size = new Size(192, 34);
            txtTongPhuCap.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 145);
            label6.Name = "label6";
            label6.Size = new Size(141, 28);
            label6.TabIndex = 6;
            label6.Text = "Tổng phụ cấp: ";
            // 
            // txtNam
            // 
            txtNam.Location = new Point(101, 139);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(203, 34);
            txtNam.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Năm: ";
            label3.Click += label3_Click;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(101, 91);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(203, 34);
            txtThang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "Tháng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân viên: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1179, 421);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Lương";
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, NhanVien, Thang, Nam, SoNgayCong, TongPhuCap, ThucLinh });
            dataGridView.DataSource = bangLuongBindingSource;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1167, 382);
            dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "ID";
            Id.FillWeight = 374.331482F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.FillWeight = 54.2780762F;
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            // 
            // Thang
            // 
            Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Thang.DataPropertyName = "Thang";
            Thang.FillWeight = 54.2780762F;
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 6;
            Thang.Name = "Thang";
            Thang.Width = 125;
            // 
            // Nam
            // 
            Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Nam.DataPropertyName = "Nam";
            Nam.FillWeight = 54.2780762F;
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            Nam.Width = 125;
            // 
            // SoNgayCong
            // 
            SoNgayCong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.FillWeight = 54.2780762F;
            SoNgayCong.HeaderText = "Số Ngày Công";
            SoNgayCong.MinimumWidth = 6;
            SoNgayCong.Name = "SoNgayCong";
            SoNgayCong.Width = 175;
            // 
            // TongPhuCap
            // 
            TongPhuCap.DataPropertyName = "TongPhuCap";
            TongPhuCap.FillWeight = 54.2780762F;
            TongPhuCap.HeaderText = "Tổng Phụ Cấp";
            TongPhuCap.MinimumWidth = 6;
            TongPhuCap.Name = "TongPhuCap";
            // 
            // ThucLinh
            // 
            ThucLinh.DataPropertyName = "ThucLinh";
            ThucLinh.FillWeight = 54.2780762F;
            ThucLinh.HeaderText = "Thực Lĩnh";
            ThucLinh.MinimumWidth = 6;
            ThucLinh.Name = "ThucLinh";
            // 
            // bangLuongBindingSource
            // 
            bangLuongBindingSource.DataSource = typeof(Data.BangLuong);
            // 
            // frmBangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 722);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBangLuong";
            Text = "Bảng Lương";
            Load += frmBangLuong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bangLuongBindingSource).EndInit();
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
        private TextBox txtThucLinh;
        private Label label5;
        private TextBox txtTongPhuCap;
        private Label label6;
        private TextBox txtNam;
        private Label label3;
        private TextBox txtThang;
        private Label label2;
        private Label label1;
        private TextBox txtSoNgayCong;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn SoNgayCong;
        private DataGridViewTextBoxColumn TongPhuCap;
        private DataGridViewTextBoxColumn ThucLinh;
        private BindingSource bangLuongBindingSource;
        private ComboBox cboNhanVien;
        private TextBox txtLuongCoBan;
        private Label label7;
    }
}