namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmPhanPhoi
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            phanPhoiBindingSource = new BindingSource(components);
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1285, 462);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Phân Phối";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colNgayLap, colGhiChu });
            dataGridView.DataSource = phanPhoiBindingSource;
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
            dataGridView.Size = new Size(1273, 423);
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
            // colNgayLap
            // 
            colNgayLap.DataPropertyName = "NgayLap";
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.MinimumWidth = 6;
            colNgayLap.Name = "colNgayLap";
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // phanPhoiBindingSource
            // 
            phanPhoiBindingSource.DataSource = typeof(Data.PhanPhoi);
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(774, 488);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Bottom;
            btnTimKiem.BackColor = Color.Fuchsia;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(599, 488);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 46);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(432, 488);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 46);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = Color.Yellow;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(272, 488);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 46);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.Lime;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(57, 488);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(181, 46);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm phân phối mới..";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.Bottom;
            btnNhap.BackColor = Color.MediumSpringGreen;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(1106, 488);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(128, 46);
            btnNhap.TabIndex = 30;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Bottom;
            btnXuat.BackColor = Color.MediumSpringGreen;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(938, 488);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 46);
            btnXuat.TabIndex = 29;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmPhanPhoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 546);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Name = "frmPhanPhoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Phối";
            WindowState = FormWindowState.Maximized;
            Load += frmPhanPhoi_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource phanPhoiBindingSource;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colDuAn;
        private DataGridViewTextBoxColumn colGhiChu;
        private Button btnNhap;
        private Button btnXuat;
    }
}