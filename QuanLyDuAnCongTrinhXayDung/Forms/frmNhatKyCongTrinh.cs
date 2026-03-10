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
    public partial class frmNhatKyCongTrinh : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmNhatKyCongTrinh()
        {
            InitializeComponent();
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
            cboDuAn.Enabled = b;
            txtGhiChu.Enabled = b;
            txtNoiDungCongViec.Enabled = b;
            dtpNgayGhi.Enabled = b;
            dataGridView.Enabled = !b;
        }
        private void ClearText()
        {
            txtGhiChu.DataBindings.Clear();
            txtNoiDungCongViec.DataBindings.Clear();
            dtpNgayGhi.DataBindings.Clear();
            cboDuAn.DataBindings.Clear();
        }
        public void LayDuAnVaoComboBox()
        {
            // Lấy danh sách dự án từ bảng DuAn trong cơ sở dữ liệu
            List<DuAn> dsDuAn = context.DuAn.ToList();
            cboDuAn.DataSource = dsDuAn;
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.ValueMember = "ID";
        }

        private void frmNhatKyCongTrinh_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();

            // 1. Nạp danh sách Dự án vào ComboBox (Giả sử bạn đã có hàm này)
            LayDuAnVaoComboBox();

            // 2. Lấy dữ liệu và "phẳng hóa" bằng Select
            dataGridView.AutoGenerateColumns = false;
            var dsNhatKy = context.NhatKyCongTrinh.Select(r => new DanhSachNhatKy
            {
                ID = r.ID,
                DuAnID = r.DuAnID,
                DuAn = r.DuAn.TenDuAn, // Lấy tên từ bảng DuAn liên kết
                NgayGhi = r.NgayGhi,
                NoiDungCongViec = r.NoiDungCongViec,
                GhiChu = r.GhiChu
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsNhatKy;

            // 3. Binding ComboBox Dự án
            cboDuAn.DataBindings.Clear();
            // Bind SelectedValue vào DuAnID của ViewNhatKy
            cboDuAn.DataBindings.Add("SelectedValue", bindingSource, "DuAnID", true, DataSourceUpdateMode.Never);

            // 4. Binding các trường còn lại
            dtpNgayGhi.DataBindings.Clear();
            dtpNgayGhi.DataBindings.Add("Value", bindingSource, "NgayGhi", true, DataSourceUpdateMode.Never);

            txtNoiDungCongViec.DataBindings.Clear();
            txtNoiDungCongViec.DataBindings.Add("Text", bindingSource, "NoiDungCongViec", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", true, DataSourceUpdateMode.Never);

            // 5. Gán Source cho DataGridView
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nếu chưa chọn dự án
                if (cboDuAn.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn dự án!");
                    return;
                }

                // 2. Lấy ID dự án (tương tự như cách lấy ID nhân viên)
                int idDuAn = Convert.ToInt32(cboDuAn.SelectedValue);

                if (xulyThem) // Chế độ Thêm mới
                {
                    NhatKyCongTrinh nk = new NhatKyCongTrinh
                    {
                        DuAnID = idDuAn, // Gán ID dự án vừa lấy được
                        NgayGhi = dtpNgayGhi.Value, // Lấy ngày từ DateTimePicker
                        NoiDungCongViec = txtNoiDungCongViec.Text, // Nội dung nhập tay
                        GhiChu = txtGhiChu.Text
                    };
                    context.NhatKyCongTrinh.Add(nk);
                }
                else // Chế độ Sửa
                {
                    // Lấy ID của dòng nhật ký đang chọn trên bảng
                    int idNK = int.Parse(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var nkUpdate = context.NhatKyCongTrinh.Find(idNK);

                    if (nkUpdate != null)
                    {
                        nkUpdate.DuAnID = idDuAn;
                        nkUpdate.NgayGhi = dtpNgayGhi.Value;
                        nkUpdate.NoiDungCongViec = txtNoiDungCongViec.Text;
                        nkUpdate.GhiChu = txtGhiChu.Text;
                    }
                }

                // 3. Lưu thay đổi xuống Database
                context.SaveChanges();
                frmNhatKyCongTrinh_Load(sender, e); // Tải lại dữ liệu để cập nhật trên giao diện
                MessageBox.Show("Đã lưu nhật ký thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trong bảng chưa
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi nhật ký cần xóa!");
                return;
            }

            // 2. Hiện hộp thoại xác nhận để tránh xóa nhầm
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Lấy ID của dòng đang chọn
                    int idNK = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                    // 4. Tìm bản ghi trong Database
                    var nhatKy = context.NhatKyCongTrinh.Find(idNK);

                    if (nhatKy != null)
                    {
                        // 5. Thực hiện xóa và lưu thay đổi
                        context.NhatKyCongTrinh.Remove(nhatKy);
                        context.SaveChanges();

                        // 6. Thông báo và làm mới dữ liệu trên bảng
                        MessageBox.Show("Đã xóa nhật ký công trình thành công!");
                        frmNhatKyCongTrinh_Load(sender, e); // Tải lại dữ liệu để cập nhật trên giao diện
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhatKyCongTrinh_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất nhật ký công trình ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "NhatKyCongTrinh_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Tên Dự Án", typeof(string));
                    table.Columns.Add("Ngày Ghi", typeof(DateTime));
                    table.Columns.Add("Nội Dung Công Việc", typeof(string));
                    table.Columns.Add("Ghi Chú", typeof(string));

                    // Truy vấn lấy dữ liệu nhật ký kèm tên dự án
                    var danhSach = context.NhatKyCongTrinh.Select(n => new
                    {
                        n.ID,
                        TenDuAn = n.DuAn.TenDuAn,
                        n.NgayGhi,
                        n.NoiDungCongViec,
                        n.GhiChu
                    }).ToList();

                    foreach (var n in danhSach)
                    {
                        table.Rows.Add(n.ID, n.TenDuAn, n.NgayGhi, n.NoiDungCongViec, n.GhiChu);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhatKy");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất nhật ký công trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            openFileDialog.Title = "Chọn file Excel nhật ký";
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
                            NhatKyCongTrinh nk = new NhatKyCongTrinh();

                            // Tìm ID Dự án theo tên dự án trong file Excel (Cột 1)
                            string tenDA = row.Cell(1).Value.ToString();
                            var duAn = context.DuAn.FirstOrDefault(d => d.TenDuAn == tenDA);

                            if (duAn != null)
                            {
                                nk.DuAnID = duAn.ID;
                                nk.NgayGhi = DateTime.Parse(row.Cell(2).Value.ToString());
                                nk.NoiDungCongViec = row.Cell(3).Value.ToString();
                                nk.GhiChu = row.Cell(4).Value.ToString();

                                context.NhatKyCongTrinh.Add(nk);
                                count++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} dòng nhật ký.", "Thành công");
                        frmNhatKyCongTrinh_Load(sender, e); // Load lại Grid của ný
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
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên dự án hoặc nội dung cần tìm:", "Tìm kiếm nhật ký", "");

            if (!string.IsNullOrEmpty(input))
            {
                var dsGoc = context.NhatKyCongTrinh.Select(n => new DanhSachNhatKy
                {
                    ID = n.ID,
                    DuAnID = n.DuAnID,
                    DuAn = n.DuAn.TenDuAn,
                    NgayGhi = n.NgayGhi,
                    NoiDungCongViec = n.NoiDungCongViec,
                    GhiChu = n.GhiChu
                }).ToList();

                // Lọc gần đúng theo Tên dự án hoặc Nội dung công việc
                var ketQua = dsGoc.Where(x => x.DuAn.ToLower().Contains(input.ToLower())
                                           || x.NoiDungCongViec.ToLower().Contains(input.ToLower())).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhật ký nào khớp với từ khóa!", "Thông báo");
                    dataGridView.DataSource = dsGoc;
                }
            }
            else
            {
                frmNhatKyCongTrinh_Load(sender, e);
            }
        }
    }
}
