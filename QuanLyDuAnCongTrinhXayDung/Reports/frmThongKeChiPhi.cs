using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyDuAnCongTrinhXayDung.Data; // Đảm bảo đúng namespace dự án của bạn
using DisplayMode = Microsoft.Reporting.WinForms.DisplayMode;

namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    public partial class frmThongKeChiPhi : Form
    {
        // 1. Khởi tạo Context để kết nối cơ sở dữ liệu
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachChiPhiDataTable danhSachChiPhiDataTable = new QLDACTXDDataSet.DanhSachChiPhiDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeChiPhi()
        {
            InitializeComponent();
        }

        private void frmThongKeChiPhi_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Truy vấn từ bảng CHI TIẾT và ép kiểu về DanhSachPhanPhoiChiTiet
                var query = context.PhanPhoiChiTiet.Select(r => new DanhSachPhanPhoiChiTiet
                {
                    ID = r.ID,
                    PhanPhoiID = r.PhanPhoiID,
                    TenVatTu = r.VatTu.TenVatTu,
                    SoLuong = r.SoLuong,
                    DonGia = r.VatTu.DonGia,
                    TongChiPhi = r.SoLuong*r.VatTu.DonGia,
                    // Nếu DataSet của bạn có cột Dự án hoặc Ngày, hãy thêm vào đây
                    TenDuAn = r.PhanPhoi.DuAn.TenDuAn,
                }).ToList();

                // 2. Làm sạch DataTable
                danhSachChiPhiDataTable.Clear();

                // 3. Nạp dữ liệu vào DataTable
                foreach (var row in query)
                {
                    // LƯU Ý: Bạn phải truyền ĐỦ tham số mà DataTable yêu cầu
                    // Chuột phải vào AddDanhSachChiPhiRow -> Go to Definition để xem thứ tự cột
                    danhSachChiPhiDataTable.AddDanhSachChiPhiRow(
                        row.ID,
                        row.PhanPhoiID,
                        row.TenVatTu,                        
                        row.SoLuong,
                        row.DonGia,
                        row.TenDuAn,
                        row.TongChiPhi
                        

                    );
                }

                // 4. Đổ dữ liệu vào ReportViewer
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DanhSachChiPhi"; // Phải khớp với Dataset Name trong file .rdlc
                rds.Value = danhSachChiPhiDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(rds);

                // 5. Thiết lập đường dẫn và chế độ hiển thị
                string reportPath = Path.Combine(reportsFolder, "rptThongKeChiPhi.rdlc");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo tại: " + reportPath);
                    return;
                }

                reportViewer.LocalReport.ReportPath = reportPath;
                reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi hiển thị báo cáo: " + msg);
            }
        }
    }
}
