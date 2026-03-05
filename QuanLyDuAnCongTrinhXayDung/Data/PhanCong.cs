using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class PhanCong
    {
        public int ID { get; set; } 
        public int DuAnID { get; set; } 
        public int NhanVienID { get; set; }
        public int CongViecID { get; set; }
        public string VaiTro { get; set; } // Ví dụ: Kỹ sư trưởng, Giám sát
        public decimal? PhuCap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int PhanTramHoanThanh { get; set; } // Tiến độ công việc (0-100)

       
        public virtual CongViec CongViec { get; set; } = null!;
        public virtual DuAn DuAn { get; set; } = null!; 
        public virtual NhanVien NhanVien { get; set; } = null!; 
    }
}