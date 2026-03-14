namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmPhanPhoiChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanPhoiChiTiet));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboVatTu = new ComboBox();
            numSoLuong = new NumericUpDown();
            txtTongChiPhi = new TextBox();
            label4 = new Label();
            btnXoa = new Button();
            numDonGia = new NumericUpDown();
            btnXacNhan = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenVatTu = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTongChiPhi = new DataGridViewTextBoxColumn();
            danhSachPhanPhoiChiTietBindingSource = new BindingSource(components);
            phanPhoiChiTietBindingSource1 = new BindingSource(components);
            phanPhoiChiTietBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cboVatTu);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtTongChiPhi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 207);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phân phối";
            // 
            // cboVatTu
            // 
            cboVatTu.FormattingEnabled = true;
            cboVatTu.Location = new Point(132, 39);
            cboVatTu.Name = "cboVatTu";
            cboVatTu.Size = new Size(356, 36);
            cboVatTu.TabIndex = 42;
            cboVatTu.SelectedIndexChanged += cboVatTu_SelectedIndexChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(132, 100);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(356, 34);
            numSoLuong.TabIndex = 41;
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // txtTongChiPhi
            // 
            txtTongChiPhi.Location = new Point(145, 164);
            txtTongChiPhi.Name = "txtTongChiPhi";
            txtTongChiPhi.Size = new Size(445, 34);
            txtTongChiPhi.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 167);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 39;
            label4.Text = "Tổng chi phí: ";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(792, 121);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 46);
            btnXoa.TabIndex = 38;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(596, 40);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(356, 34);
            numDonGia.TabIndex = 37;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSpringGreen;
            btnXacNhan.ForeColor = Color.Black;
            btnXacNhan.Location = new Point(625, 121);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(129, 46);
            btnXacNhan.TabIndex = 22;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 4;
            label3.Text = "Số lượng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 41);
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(669, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = Color.Silver;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(620, 724);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Bottom;
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(450, 724);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 46);
            btnHuyBo.TabIndex = 19;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.BackColor = Color.Cyan;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(286, 724);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 421);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chi tiết";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colTenVatTu, colSoLuong, colDonGia, colTongChiPhi });
            dataGridView.DataSource = danhSachPhanPhoiChiTietBindingSource;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(990, 382);
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
            // colTenVatTu
            // 
            colTenVatTu.DataPropertyName = "TenVatTu";
            colTenVatTu.HeaderText = "Tên Vật Tư";
            colTenVatTu.MinimumWidth = 6;
            colTenVatTu.Name = "colTenVatTu";
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colTongChiPhi
            // 
            colTongChiPhi.DataPropertyName = "TongChiPhi";
            colTongChiPhi.HeaderText = "Tổng chi phí";
            colTongChiPhi.MinimumWidth = 6;
            colTongChiPhi.Name = "colTongChiPhi";
            // 
            // danhSachPhanPhoiChiTietBindingSource
            // 
            danhSachPhanPhoiChiTietBindingSource.DataSource = typeof(Data.DanhSachPhanPhoiChiTiet);
            // 
            // phanPhoiChiTietBindingSource1
            // 
            phanPhoiChiTietBindingSource1.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // phanPhoiChiTietBindingSource
            // 
            phanPhoiChiTietBindingSource.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // frmPhanPhoiChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 782);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Name = "frmPhanPhoiChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Phối Chi Tiết";
            WindowState = FormWindowState.Maximized;
            Load += frmPhanPhoiChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numDonGia;
        private Button btnXacNhan;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource phanPhoiChiTietBindingSource;
        private BindingSource phanPhoiChiTietBindingSource1;
        private BindingSource danhSachPhanPhoiChiTietBindingSource;
        private Button btnXoa;
        private NumericUpDown numSoLuong;
        private TextBox txtTongChiPhi;
        private Label label4;
        private ComboBox cboVatTu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenVatTu;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTongChiPhi;
        private PictureBox pictureBox1;
    }
}