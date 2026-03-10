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
    public partial class frmPhanPhoi : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        int id;
        public frmPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmPhanPhoi_Load(object sender, EventArgs e)
        {
            // Tắt tự động tạo cột để khớp với các cột bạn đã vẽ thủ công trên giao diện
            dataGridView.AutoGenerateColumns = false;

            // Khai báo List theo class phụ vừa tạo
            List<DanhSachPhanPhoi> ds = new List<DanhSachPhanPhoi>();

            // Truy vấn dữ liệu từ context
            ds = context.PhanPhoi.Select(r => new DanhSachPhanPhoi
            {
                ID = (int)r.ID,
                NgayLap = r.NgayLap,
                DuAnID = (int)r.DuAnID,
                TenDuAn = r.DuAn.TenDuAn, // Lấy tên dự án từ bảng liên kết
                GhiChu = r.GhiChu
            }).ToList();

            // Gán nguồn dữ liệu cho bảng
            dataGridView.DataSource = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhanPhoiChiTiet f = new frmPhanPhoiChiTiet(0);
            f.ShowDialog();

            // Sau khi đóng form chi tiết, nạp lại danh sách ở form chính để thấy phiếu mới
            frmPhanPhoi_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var cellValue = dataGridView.CurrentRow.Cells["colID"].Value;
                if (cellValue != null)
                {
                    id = Convert.ToInt32(cellValue);
                    // Mở form sửa và truyền ID vào
                    using (frmPhanPhoiChiTiet f = new frmPhanPhoiChiTiet(id)) { f.ShowDialog(); }
                    frmPhanPhoi_Load(sender, e); // Tải lại dữ liệu sau khi sửa
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa bản ghi phân phối này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                    var pp = context.PhanPhoi.Find(id);
                    if (pp != null)
                    {
                        context.PhanPhoi.Remove(pp);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        frmPhanPhoi_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1. Hỏi người dùng muốn xuất loại dữ liệu nào
            DialogResult result = MessageBox.Show(
                "Bạn muốn xuất loại dữ liệu nào?\n\n- Chọn 'Yes': Xuất Danh sách Phân phối\n- Chọn 'No': Xuất Chi tiết",
                "Tùy chọn Xuất Excel",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Cancel) return;

            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" };

            if (result == DialogResult.Yes)
            {
                sfd.FileName = "DanhSachPhanPhoi_" + DateTime.Now.ToString("dd_MM_yyyy");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã Phân Phối", typeof(int));
                    table.Columns.Add("Ngày Lập", typeof(DateTime));
                    table.Columns.Add("Dự Án", typeof(string));
                    table.Columns.Add("Ghi Chú", typeof(string));

                    var ds = context.PhanPhoi.Select(p => new
                    {
                        p.ID,
                        p.NgayLap,
                        TenDA = p.DuAn.TenDuAn,
                        p.GhiChu
                    }).ToList();

                    foreach (var p in ds) table.Rows.Add(p.ID, p.NgayLap, p.TenDA, p.GhiChu);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(table, "PhanPhoi_TongHop");
                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName); // Sử dụng sfd.FileName thay cho filePath bị lỗi
                        MessageBox.Show("Xuất danh sách phiếu thành công!");
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                sfd.FileName = "ChiTietPhanPhoi_" + DateTime.Now.ToString("dd_MM_yyyy");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã Phân Phối", typeof(int));
                    table.Columns.Add("Tên Vật Tư", typeof(string));
                    table.Columns.Add("Số Lượng", typeof(int));
                    table.Columns.Add("Đơn Giá", typeof(decimal));
                    table.Columns.Add("Tổng Tiền", typeof(decimal));

                    var dsChiTiet = context.PhanPhoiChiTiet.Select(ct => new
                    {
                        ct.PhanPhoiID,
                        TenVT = ct.VatTu.TenVatTu,
                        ct.SoLuong,
                        Gia = ct.VatTu.DonGia,
                        ThanhTien = (decimal)ct.SoLuong * ct.VatTu.DonGia
                    }).ToList();

                    foreach (var ct in dsChiTiet) table.Rows.Add(ct.PhanPhoiID, ct.TenVT, ct.SoLuong, ct.Gia, ct.ThanhTien);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(table, "ChiTiet_VatTu");
                        ws.Column(4).Style.NumberFormat.Format = "#,##0";
                        ws.Column(5).Style.NumberFormat.Format = "#,##0";
                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName); // Sử dụng sfd.FileName ở đây luôn
                        MessageBox.Show("Xuất chi tiết vật tư thành công!");
                    }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Ný muốn nhập dữ liệu từ file nào?\n\n- Chọn 'Yes': Nhập Danh sách Phân phối\n- Chọn 'No': Nhập Chi tiết",
         "Tùy chọn Nhập", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel) return;

            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1);
                        int count = 0;

                        if (result == DialogResult.Yes)
                        {
                            foreach (var row in rows)
                            {
                                // Cột 1: Tên Dự Án, Cột 2: Ngày Lập, Cột 3: Ghi Chú
                                string tenDA = row.Cell(1).Value.ToString();
                                var duAn = context.DuAn.FirstOrDefault(d => d.TenDuAn == tenDA);
                                if (duAn != null)
                                {
                                    context.PhanPhoi.Add(new PhanPhoi
                                    {
                                        DuAnID = duAn.ID,
                                        NgayLap = DateTime.Parse(row.Cell(2).Value.ToString()),
                                        GhiChu = row.Cell(3).Value.ToString()
                                    });
                                    count++;
                                }
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            foreach (var row in rows)
                            {
                                // Cột 1: Mã phân phối (ID), Cột 2: Tên Vật Tư, Cột 3: Số Lượng
                                int maPP = int.Parse(row.Cell(1).Value.ToString());
                                string tenVT = row.Cell(2).Value.ToString();
                                var vatTu = context.VatTu.FirstOrDefault(v => v.TenVatTu == tenVT);

                                if (vatTu != null && context.PhanPhoi.Any(p => p.ID == maPP))
                                {
                                    context.PhanPhoiChiTiet.Add(new PhanPhoiChiTiet
                                    {
                                        PhanPhoiID = maPP,
                                        VatTuID = vatTu.ID,
                                        SoLuong = int.Parse(row.Cell(3).Value.ToString())
                                    });
                                    count++;
                                }
                            }
                        }
                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} dòng!", "Thành công");
                        frmPhanPhoi_Load(sender, e);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên dự án hoặc ghi chú cần tìm:", "Tìm kiếm phiếu", "");

            if (!string.IsNullOrEmpty(input))
            {
                var dsGoc = context.PhanPhoi.Select(p => new DanhSachPhanPhoi
                {
                    ID = p.ID,
                    NgayLap = p.NgayLap,
                    DuAnID = p.DuAnID,
                    TenDuAn = p.DuAn.TenDuAn,
                    GhiChu = p.GhiChu
                }).ToList();

                // Lọc gần đúng theo tên dự án hoặc ghi chú
                var ketQua = dsGoc.Where(x => x.TenDuAn.ToLower().Contains(input.ToLower())
                                           || (x.GhiChu != null && x.GhiChu.ToLower().Contains(input.ToLower()))).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nào khớp với từ khóa!", "Thông báo");
                    dataGridView.DataSource = dsGoc;
                }
            }
            else
            {
                frmPhanPhoi_Load(sender, e);
            }
        }
    }
}
