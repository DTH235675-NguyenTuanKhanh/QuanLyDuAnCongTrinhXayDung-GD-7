using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class NhanVien
    {
        public int ID { get; set; } 
        public string HoVaTen { get; set; } 
        public string? DienThoai { get; set; } 
        public string? DiaChi { get; set; }
        public string? ChuyenMon { get; set; }
        public decimal LuongCoBan { get; set; } // Lương theo ngày hoặc tháng
        public string TenDangNhap { get; set; } 
        public string MatKhau { get; set; } 
        public bool QuyenHan { get; set; } 

        // Liên kết đến bảng Phân công để lấy phụ cấp
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new(); 
    }
}