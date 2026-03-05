using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class DuAn
    {
        public int ID { get; set; }
        public string TenDuAn { get; set; }
        public string? DiaDiem { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal NganSach { get; set; }
        public int LoaiDuAnID { get; set; } 
       

        // Khóa ngoại
        public int KhachHangID { get; set; }
        public int NhaDauTuID { get; set; }

        // Navigation Properties
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhaDauTu NhaDauTu { get; set; } = null!;
        public virtual LoaiDuAn LoaiDuAn { get; set; } = null!;


        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
        public virtual ObservableCollectionListSource<VatTuChiTiet> VatTuChiTiet { get; } = new();
    }
}