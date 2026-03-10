using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class VatTu
    {
        public int ID { get; set; } 
        public string TenVatTu { get; set; } 
        public string DonViTinh { get; set; } 
        public decimal DonGia { get; set; }
        public string? HinhAnh { get; set; } // Đường dẫn hoặc URL đến hình ảnh liên quan đến phân phối

        public virtual ObservableCollectionListSource<PhanPhoiChiTiet> PhanPhoiChiTiet { get;  } = new();
    }
    public class DanhSachVatTu
    {
        public int ID { get; set; }
        public string TenVatTu { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public string? HinhAnh { get; set; }
    }
}