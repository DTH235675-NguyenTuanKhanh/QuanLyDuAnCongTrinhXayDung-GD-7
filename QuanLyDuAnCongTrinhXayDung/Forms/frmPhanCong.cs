using ClosedXML.Excel;
using QuanLyDuAnCongTrinhXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAnCongTrinhXayDung.Forms
{

    public partial class frmPhanCong : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmPhanCong()
        {
            InitializeComponent();
        }
        public void LayDuAnVaoComboBox()
        {
            List<DuAn> dsDuAn = context.DuAn.ToList();
            cboTenDuAn.DataSource = dsDuAn;
            cboTenDuAn.DisplayMember = "TenDuAn";
            cboTenDuAn.ValueMember = "ID";
        }
        public void LayNhanVienVaoComboBox()
        {
            List<NhanVien> dsNhanVien = context.NhanVien.ToList();
            cboNhanVien.DataSource = dsNhanVien;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
        }
        public void LayCongViecVaoComboBox()
        {
            List<CongViec> dsCongViec = context.CongViec.ToList();
            cboTenCongViec.DataSource = dsCongViec;
            cboTenCongViec.DisplayMember = "TenCongViec";
            cboTenCongViec.ValueMember = "ID";
        }
        private void BatTatChucNang(bool b)
        {
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnLuu.Enabled = b;
            btnHuyBo.Enabled = b;
            btnTimKiem.Enabled = !b;
            btnThoat.Enabled = !b;
            btnNhap.Enabled = !b;
            btnXuat.Enabled = !b;
            cboTenDuAn.Enabled = b;
            cboNhanVien.Enabled = b;
            cboTenCongViec.Enabled = b;
            txtPhuCap.Enabled = b;
            txtVaiTro.Enabled = b;
            txtTienDo.Enabled = b;
            dtpNgayBatDau.Enabled = b;
            dtpNgayKetThuc.Enabled = b;
            dataGridView.Enabled = !b;
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            // 0. Khóa các control nhập liệu ban đầu
            BatTatChucNang(false);

            // 1. Nạp dữ liệu vào các ComboBox hỗ trợ
            // Các hàm này cần nạp DataSource, DisplayMember và ValueMember
            LayDuAnVaoComboBox();
            LayNhanVienVaoComboBox();
            LayCongViecVaoComboBox();

            dataGridView.AutoGenerateColumns = false;

            // 2. Lấy dữ liệu và map vào class DanhSachPhanCong để hiện Tên thay vì ID
            List<DanhSachPhanCong> ds = context.PhanCong.Select(r => new DanhSachPhanCong
            {
                ID = r.ID,
                DuAnID = r.DuAnID, // Khóa ngoại kết nối ComboBox
                TenDuAn = r.DuAn.TenDuAn,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.HoVaTen,
                CongViecID = r.CongViecID,
                TenCongViec = r.CongViec.TenCongViec,
                VaiTro = r.VaiTro, //
                PhuCap = r.PhuCap ?? 0, // Xử lý nếu Phụ cấp null
                NgayBatDau = r.NgayBatDau,
                NgayKetThuc = r.NgayKetThuc,
                PhanTramHoanThanh = r.PhanTramHoanThanh //
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;

            // 3. Binding các ComboBox (Kết nối ID từ class với SelectedValue của Combo)
            cboTenDuAn.DataBindings.Clear();
            cboTenDuAn.DataBindings.Add("SelectedValue", bindingSource, "DuAnID", true, DataSourceUpdateMode.Never);

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bindingSource, "NhanVienID", true, DataSourceUpdateMode.Never);

            cboTenCongViec.DataBindings.Clear();
            cboTenCongViec.DataBindings.Add("SelectedValue", bindingSource, "CongViecID", true, DataSourceUpdateMode.Never);

            // 4. Binding các TextBox và DateTimePicker
            txtVaiTro.DataBindings.Clear();
            txtVaiTro.DataBindings.Add("Text", bindingSource, "VaiTro", true, DataSourceUpdateMode.Never);

            txtPhuCap.DataBindings.Clear();
            txtPhuCap.DataBindings.Add("Text", bindingSource, "PhuCap", true, DataSourceUpdateMode.Never);

            dtpNgayBatDau.DataBindings.Clear();
            dtpNgayBatDau.DataBindings.Add("Value", bindingSource, "NgayBatDau", true, DataSourceUpdateMode.Never);

            dtpNgayKetThuc.DataBindings.Clear();
            dtpNgayKetThuc.DataBindings.Add("Value", bindingSource, "NgayKetThuc", true, DataSourceUpdateMode.Never);

            txtTienDo.DataBindings.Clear();
            txtTienDo.DataBindings.Add("Text", bindingSource, "PhanTramHoanThanh", true, DataSourceUpdateMode.Never);

            // 5. Gán Source cho Grid
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtPhuCap.DataBindings.Clear();
            txtVaiTro.DataBindings.Clear();
            txtTienDo.DataBindings.Clear();
            cboTenDuAn.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboTenCongViec.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phân công công việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                PhanCong pc = context.PhanCong.Find(id);
                if (pc != null)
                {
                    context.PhanCong.Remove(pc);
                    context.SaveChanges();
                    MessageBox.Show("Xóa phân công công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPhanCong_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào cơ bản
                if (cboTenDuAn.SelectedValue == null || cboNhanVien.SelectedValue == null || cboTenCongViec.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ Dự án, Nhân viên và Công việc!");
                    return;
                }

                // 2. Lấy dữ liệu từ giao diện
                int idDuAn = Convert.ToInt32(cboTenDuAn.SelectedValue);
                int idNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                int idCV = Convert.ToInt32(cboTenCongViec.SelectedValue);

                decimal phuCap = 0;
                decimal.TryParse(txtPhuCap.Text, out phuCap);

                int phanTram = 0;
                int.TryParse(txtTienDo.Text, out phanTram);

                DateTime ngayBD = dtpNgayBatDau.Value;
                DateTime ngayKT = dtpNgayKetThuc.Value;

                // Kiểm tra logic ngày tháng của việc phân công
                if (ngayKT < ngayBD)
                {
                    MessageBox.Show("Ngày kết thúc làm việc không được nhỏ hơn ngày bắt đầu!");
                    return;
                }

                // 3. Thực hiện Lưu (Thêm mới hoặc Sửa)
                if (xulyThem)
                {
                    PhanCong pc = new PhanCong
                    {
                        DuAnID = idDuAn,
                        NhanVienID = idNV,
                        CongViecID = idCV,
                        VaiTro = txtVaiTro.Text, //
                        PhuCap = phuCap, //
                        NgayBatDau = ngayBD,
                        NgayKetThuc = ngayKT,
                        PhanTramHoanThanh = phanTram //
                    };
                    context.PhanCong.Add(pc);
                    MessageBox.Show("Thêm phân công thành công!");
                }
                else
                {
                    // Trường hợp Sửa: Sử dụng biến 'id' toàn cục đã lấy từ Grid khi nhấn nút Sửa
                    var pcEdit = context.PhanCong.Find(id);
                    if (pcEdit != null)
                    {
                        pcEdit.DuAnID = idDuAn;
                        pcEdit.NhanVienID = idNV;
                        pcEdit.CongViecID = idCV;
                        pcEdit.VaiTro = txtVaiTro.Text;
                        pcEdit.PhuCap = phuCap;
                        pcEdit.NgayBatDau = ngayBD;
                        pcEdit.NgayKetThuc = ngayKT;
                        pcEdit.PhanTramHoanThanh = phanTram;
                    }
                    MessageBox.Show("Cập nhật phân công thành công!");
                }

                // 4. Cập nhật vào Cơ sở dữ liệu
                context.SaveChanges();

                // 5. Làm mới giao diện
                BatTatChucNang(false); // Mở khóa lại DataGridView
                frmPhanCong_Load(sender, e); // Nạp lại dữ liệu vào class DanhSachPhanCong
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhanCong_Load(sender, e); // Tải lại dữ liệu để hủy bỏ mọi thay đổi chưa lưu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách phân công ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "PhanCong_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Dự Án", typeof(string));
                    table.Columns.Add("Nhân Viên", typeof(string));
                    table.Columns.Add("Công Việc", typeof(string));
                    table.Columns.Add("Vai Trò", typeof(string));
                    table.Columns.Add("Phụ Cấp", typeof(decimal));
                    table.Columns.Add("Bắt Đầu", typeof(DateTime));
                    table.Columns.Add("Kết Thúc", typeof(DateTime));
                    table.Columns.Add("% Hoàn Thành", typeof(int));

                    var danhSach = context.PhanCong.Select(p => new
                    {
                        p.ID,
                        TenDuAn = p.DuAn.TenDuAn,
                        TenNV = p.NhanVien.HoVaTen,
                        TenCV = p.CongViec.TenCongViec,
                        p.VaiTro,
                        PhuCap = p.PhuCap ?? 0,
                        p.NgayBatDau,
                        p.NgayKetThuc,
                        p.PhanTramHoanThanh
                    }).ToList();

                    foreach (var p in danhSach)
                    {
                        table.Rows.Add(p.ID, p.TenDuAn, p.TenNV, p.TenCV, p.VaiTro, p.PhuCap, p.NgayBatDau, p.NgayKetThuc, p.PhanTramHoanThanh);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "PhanCong");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất danh sách phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file Excel phân công";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1);

                        int count = 0;
                        foreach (var row in rows)
                        {
                            PhanCong pc = new PhanCong();

                            // Tìm các ID từ Tên trong Excel
                            string tenDA = row.Cell(1).Value.ToString();
                            var da = context.DuAn.FirstOrDefault(d => d.TenDuAn == tenDA);

                            string tenNV = row.Cell(2).Value.ToString();
                            var nv = context.NhanVien.FirstOrDefault(n => n.HoVaTen == tenNV);

                            string tenCV = row.Cell(3).Value.ToString();
                            var cv = context.CongViec.FirstOrDefault(c => c.TenCongViec == tenCV);

                            if (da != null && nv != null && cv != null)
                            {
                                pc.DuAnID = da.ID;
                                pc.NhanVienID = nv.ID;
                                pc.CongViecID = cv.ID;
                                pc.VaiTro = row.Cell(4).Value.ToString();
                                pc.PhuCap = decimal.Parse(row.Cell(5).Value.ToString());
                                pc.NgayBatDau = DateTime.Parse(row.Cell(6).Value.ToString());
                                pc.NgayKetThuc = DateTime.Parse(row.Cell(7).Value.ToString());
                                pc.PhanTramHoanThanh = int.Parse(row.Cell(8).Value.ToString());

                                context.PhanCong.Add(pc);
                                count++;
                            }
                        }
                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} bản ghi phân công.", "Thành công");
                        frmPhanCong_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập file: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên nhân viên hoặc tên dự án cần tìm:", "Tìm kiếm phân công", "");

            if (!string.IsNullOrEmpty(input))
            {
                var dsGoc = context.PhanCong.Select(p => new DanhSachPhanCong
                {
                    ID = p.ID,
                    TenDuAn = p.DuAn.TenDuAn,
                    TenNhanVien = p.NhanVien.HoVaTen,
                    TenCongViec = p.CongViec.TenCongViec,
                    VaiTro = p.VaiTro,
                    PhuCap = p.PhuCap ?? 0,
                    NgayBatDau = p.NgayBatDau,
                    NgayKetThuc = p.NgayKetThuc,
                    PhanTramHoanThanh = p.PhanTramHoanThanh
                }).ToList();

                var ketQua = dsGoc.Where(x => x.TenNhanVien.ToLower().Contains(input.ToLower())
                                           || x.TenDuAn.ToLower().Contains(input.ToLower())).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin phân công nào khớp!", "Thông báo");
                    dataGridView.DataSource = dsGoc;
                }
            }
            else
            {
                frmPhanCong_Load(sender, e);
            }
        }
    }
}
