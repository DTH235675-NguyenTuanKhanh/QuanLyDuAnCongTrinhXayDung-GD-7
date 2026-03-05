using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenCongTy { get; set; } // Tên công ty khách hàng
        public string? MaSoThue { get; set; } // Mã số thuế doanh nghiệp
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public string? NguoiDaiDien { get; set; } // Người liên hệ trực tiếp

        // Một công ty khách hàng có thể có nhiều dự án đang thuê thi công
        public virtual ObservableCollectionListSource<DuAn> DuAn { get; } = new();
    }
}