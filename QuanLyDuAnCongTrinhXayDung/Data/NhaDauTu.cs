using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class NhaDauTu
    {
        public int ID { get; set; }
        public string TenNhaDauTu { get; set; }
        public string? MaSoThue { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }

        // Danh sách dự án mà đơn vị này rót vốn
        public virtual ObservableCollectionListSource<DuAn> DuAn { get; } = new();
    }
}