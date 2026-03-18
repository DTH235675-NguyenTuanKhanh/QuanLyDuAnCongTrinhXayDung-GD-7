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
    public partial class frmThongKeLuong : Form
    {
        // 1. Khởi tạo Context và DataTable phù hợp với dữ liệu Lương
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachLuongDataTable danhSachLuongDataTable = new QLDACTXDDataSet.DanhSachLuongDataTable();

        // 2. Cấu hình đường dẫn khớp với phiên bản .NET bạn đang dùng (net9.0)
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeLuong()
        {
            InitializeComponent();
        }
        private void frmThongKeLuong_Load(object sender, EventArgs e)
        {
            try
            {
                // 3. Truy vấn dữ liệu từ bảng BangLuong và NhanVien
                // Flatten dữ liệu để đưa vào DataTable phẳng
                var danhSachLuong = context.BangLuong.Select(r => new DanhSachBangLuong
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    TenNhanVien = r.NhanVien.HoVaTen, // Giả sử thuộc tính là HoTen
                    Thang = r.Thang,
                    Nam = r.Nam,
                    SoNgayCong = r.SoNgayCong,
                    TongPhuCap = r.TongPhuCap,
                    ThucLinh = r.ThucLinh
                
                }).ToList(); 

                // 4. Xóa dữ liệu cũ và đổ dữ liệu mới vào DataTable của DataSet
                 danhSachLuongDataTable.Clear(); 
                foreach (var row in danhSachLuong)
                {
                    danhSachLuongDataTable.AddDanhSachLuongRow(
                        row.ID,                        
                        row.NhanVienID,
                        row.TenNhanVien,
                        row.Thang,
                        row.Nam,
                        row.SoNgayCong,
                        row.TongPhuCap,
                        row.ThucLinh
                        
                   ); 
                }

                // 5. Cấu hình nguồn dữ liệu cho Report
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachLuong"; // Tên này PHẢI trùng với tên trong file .rdlc
                 reportDataSource.Value = danhSachLuongDataTable; 

                 reportViewer.LocalReport.DataSources.Clear(); 
                 reportViewer.LocalReport.DataSources.Add(reportDataSource); 
                
                // 6. Kết nối file rptThongKeLuong.rdlc
                 string reportPath = Path.Combine(reportsFolder, "rptThongKeLuong.rdlc"); 
                reportViewer.LocalReport.ReportPath = reportPath;

                // 7. Định dạng hiển thị chuyên nghiệp
                 reportViewer.SetDisplayMode(DisplayMode.PrintLayout); 
                 reportViewer.ZoomMode = ZoomMode.Percent; 
                 reportViewer.ZoomPercent = 100; 

                reportViewer.RefreshReport(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo lương: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
