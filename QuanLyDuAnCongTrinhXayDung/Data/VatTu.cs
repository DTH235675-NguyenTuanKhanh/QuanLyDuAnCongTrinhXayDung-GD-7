using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class VatTu
    {
        public int ID { get; set; } 
        public string TenVatTu { get; set; } 
        public string DonViTinh { get; set; } 
        public decimal DonGia { get; set; } 

        public virtual ObservableCollectionListSource<VatTuChiTiet> ChiPhiVatTu { get; } = new(); 
    }
}