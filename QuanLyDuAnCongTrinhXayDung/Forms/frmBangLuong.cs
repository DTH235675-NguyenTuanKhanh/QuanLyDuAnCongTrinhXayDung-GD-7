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
using OfficeOpenXml;
using System.IO;


namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmBangLuong : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmBangLuong()
        {
            InitializeComponent();
        }
        public void LayNhanVienVaoComboBox()
        {
            List<NhanVien> dsNhanVien = context.NhanVien.ToList();
            cboNhanVien.DataSource = dsNhanVien;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
        }
        public void layLuongCoBan()
        {
            int idNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
            NhanVien nv = context.NhanVien.Find(idNhanVien);
            if (nv != null)
            {
                txtLuongCoBan.Text = nv.LuongCoBan.ToString();
            }
        }
        public void layphuCap()
        {
            int idNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
            decimal tongPhuCap = context.PhanCong
                .Where(pc => pc.NhanVienID == idNhanVien)
                .Sum(pc => pc.PhuCap) ?? 0; // Nếu null thì bằng 0
            txtTongPhuCap.Text = tongPhuCap.ToString();
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
            cboNhanVien.Enabled = b;
            txtNam.Enabled = b;
            txtThang.Enabled = b;
            txtSoNgayCong.Enabled = b;
            txtTongPhuCap.Enabled = b;
            txtThucLinh.Enabled = b;
            txtLuongCoBan.Enabled = b;
            dataGridView.Enabled = !b;
        }
        private void ClearText()
        {
            txtNam.DataBindings.Clear();
            txtThang.DataBindings.Clear();
            txtSoNgayCong.DataBindings.Clear();
            txtTongPhuCap.DataBindings.Clear();
            txtThucLinh.DataBindings.Clear();
            txtLuongCoBan.DataBindings.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayNhanVienVaoComboBox(); // Đảm bảo nạp NhanVien trước

            dataGridView.AutoGenerateColumns = false;

            // SỬA TẠI ĐÂY: Sử dụng Class DanhSachBangLuong thay vì kiểu ẩn danh
            List<DanhSachBangLuong> ds = context.BangLuong.Select(r => new DanhSachBangLuong
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID, // Khóa ngoại kết nối với ComboBox
                TenNhanVien = r.NhanVien.HoVaTen, // Dùng để hiển thị hoặc kiểm tra
                Thang = r.Thang,
                Nam = r.Nam,
                SoNgayCong = r.SoNgayCong,
                TongPhuCap = r.TongPhuCap,
                ThucLinh = r.ThucLinh
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;

            // Binding ComboBox (Đảm bảo NhanVienID khớp với ValueMember của ComboBox)
            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bindingSource, "NhanVienID", true, DataSourceUpdateMode.Never);

            // Binding các TextBox khác
            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", bindingSource, "Thang", true, DataSourceUpdateMode.Never);

            // 4. Binding các TextBox
            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", bindingSource, "Thang", true, DataSourceUpdateMode.Never);

            txtNam.DataBindings.Clear();
            txtNam.DataBindings.Add("Text", bindingSource, "Nam", true, DataSourceUpdateMode.Never);

            txtSoNgayCong.DataBindings.Clear();
            txtSoNgayCong.DataBindings.Add("Text", bindingSource, "SoNgayCong", true, DataSourceUpdateMode.Never);

            txtTongPhuCap.DataBindings.Clear();
            txtTongPhuCap.DataBindings.Add("Text", bindingSource, "TongPhuCap", true, DataSourceUpdateMode.Never);

            txtThucLinh.DataBindings.Clear();
            txtThucLinh.DataBindings.Add("Text", bindingSource, "ThucLinh", true, DataSourceUpdateMode.Never);

            // 5. Gán Source cho Grid
            dataGridView.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lương của nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                BangLuong bl = context.BangLuong.Find(id);
                if (bl != null)
                {
                    context.BangLuong.Remove(bl);
                    context.SaveChanges();
                    MessageBox.Show("Xóa lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    frmBangLuong_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào cơ bản
                if (cboNhanVien.SelectedValue == null || string.IsNullOrEmpty(txtThang.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên và thời gian!");
                    return;
                }

                // 2. Lấy ID nhân viên từ ComboBox (sử dụng ValueMember là "Id")
                int idNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                decimal tongPhuCap = context.PhanCong
                .Where(pc => pc.NhanVienID == idNV)
                .Sum(pc => pc.PhuCap) ?? 0; // Nếu null thì bằng 0
                // 3. Tính toán Thực Lĩnh
                // Lấy Lương Cơ Bản từ database (giống logic hàm layLuongCoBan của bạn)
                var nv = context.NhanVien.Find(idNV);
                if (nv == null) return;

                decimal luongCoBan = nv.LuongCoBan;
                int soNgayCong = int.Parse(txtSoNgayCong.Text);


                // Công thức: ThucLinh = (LuongCoBan * SoNgayCong) + TongPhuCap
                decimal thucLinh = (luongCoBan * soNgayCong) + tongPhuCap;

                // Hiển thị lên giao diện
                txtThucLinh.Text = thucLinh.ToString();

                // 4. Thực hiện Lưu (Thêm mới hoặc Sửa)
                if (xulyThem) // Giả định bạn dùng biến flag này khi nhấn nút 'Thêm'
                {
                    BangLuong bl = new BangLuong
                    {
                        NhanVienID = idNV,
                        Thang = int.Parse(txtThang.Text),
                        Nam = int.Parse(txtNam.Text),
                        SoNgayCong = soNgayCong,
                        TongPhuCap = tongPhuCap,
                        ThucLinh = thucLinh
                    };
                    context.BangLuong.Add(bl);
                    MessageBox.Show("Thêm bảng lương thành công!");
                }
                else
                {
                    // Trường hợp Sửa: Tìm bản ghi hiện tại qua ID trên GridView
                    int idRecord = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
                    var blEdit = context.BangLuong.Find(idRecord);
                    if (blEdit != null)
                    {
                        blEdit.NhanVienID = idNV;
                        blEdit.Thang = int.Parse(txtThang.Text);
                        blEdit.Nam = int.Parse(txtNam.Text);
                        blEdit.SoNgayCong = soNgayCong;
                        blEdit.TongPhuCap = tongPhuCap;
                        blEdit.ThucLinh = thucLinh;
                    }
                    MessageBox.Show("Cập nhật thành công!");
                }

                // 5. Cập nhật DB và làm mới bảng dữ liệu
                context.SaveChanges();
                frmBangLuong_Load(sender, e);
                // Hàm nạp lại dữ liệu lên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmBangLuong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách bảng lương ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "BangLuong_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Tên Nhân Viên", typeof(string));
                    table.Columns.Add("Tháng", typeof(int));
                    table.Columns.Add("Năm", typeof(int));
                    table.Columns.Add("Số Ngày Công", typeof(int));
                    table.Columns.Add("Tổng Phụ Cấp", typeof(decimal));
                    table.Columns.Add("Thực Lĩnh", typeof(decimal));

                    // Lấy dữ liệu bảng lương kèm tên nhân viên từ bảng liên kết
                    var danhSach = context.BangLuong.Select(b => new
                    {
                        b.ID,
                        TenNhanVien = b.NhanVien.HoVaTen,
                        b.Thang,
                        b.Nam,
                        b.SoNgayCong,
                        b.TongPhuCap,
                        b.ThucLinh
                    }).ToList();

                    foreach (var b in danhSach)
                    {
                        table.Rows.Add(b.ID, b.TenNhanVien, b.Thang, b.Nam, b.SoNgayCong, b.TongPhuCap, b.ThucLinh);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "BangLuong");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            openFileDialog.Title = "Chọn file Excel bảng lương";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua tiêu đề

                        int count = 0;
                        foreach (var row in rows)
                        {
                            BangLuong bl = new BangLuong();

                            // Giả sử cột 1: Tên NV, cột 2: Tháng, cột 3: Năm, cột 4: Số ngày công, cột 5: Phụ cấp, cột 6: Thực lĩnh
                            string tenNV = row.Cell(1).Value.ToString();
                            var nv = context.NhanVien.FirstOrDefault(n => n.HoVaTen == tenNV);

                            if (nv != null)
                            {
                                bl.NhanVienID = nv.ID;
                                bl.Thang = int.Parse(row.Cell(2).Value.ToString());
                                bl.Nam = int.Parse(row.Cell(3).Value.ToString());
                                bl.SoNgayCong = int.Parse(row.Cell(4).Value.ToString());
                                bl.TongPhuCap = decimal.Parse(row.Cell(5).Value.ToString());
                                bl.ThucLinh = decimal.Parse(row.Cell(6).Value.ToString());

                                context.BangLuong.Add(bl);
                                count++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} bản ghi lương.", "Thành công");
                        frmBangLuong_Load(sender, e); // Load lại DataGridView của ný
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập tên nhân viên
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên nhân viên cần tìm:", "Tìm kiếm lương", "");

            if (!string.IsNullOrEmpty(input))
            {
                // Lấy toàn bộ danh sách hiện tại từ Database
                var dsGoc = context.BangLuong.Select(b => new DanhSachBangLuong
                {
                    ID = b.ID,
                    NhanVienID = b.NhanVienID,
                    TenNhanVien = b.NhanVien.HoVaTen, // Lấy tên từ bảng NhanVien
                    Thang = b.Thang,
                    Nam = b.Nam,
                    SoNgayCong = b.SoNgayCong,
                    TongPhuCap = b.TongPhuCap,
                    ThucLinh = b.ThucLinh
                }).ToList();

                // Lọc danh sách theo tên (chứa từ khóa nhập vào)
                var ketQua = dsGoc.Where(x => x.TenNhanVien.ToLower().Contains(input.ToLower())).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào có tên này trong bảng lương!", "Thông báo");
                    dataGridView.DataSource = dsGoc; // Hiện lại toàn bộ nếu không thấy
                }
            }
            else
            {
                // Nếu để trống, load lại toàn bộ dữ liệu
                frmBangLuong_Load(sender, e);
            }
        }
    }
}
