using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class CongViec
    {
        public int ID { get; set; } 
        
        public string TenCongViec { get; set; }
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
    }
}