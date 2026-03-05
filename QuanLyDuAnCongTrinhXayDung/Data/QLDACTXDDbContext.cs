using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class QLDACTXDDbContext : DbContext
    {
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhaDauTu> NhaDauTu { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<CongViec> CongViec { get; set; }
        public DbSet<VatTu> VatTu { get; set; }
        public DbSet<VatTuChiTiet> VatTuChiTiet { get; set; }
        public DbSet<BangLuong> BangLuong { get; set; }
        public DbSet<LoaiDuAn> LoaiDuAn { get; set; }
        public DbSet<NhatKyCongTrinh> NhatKyCongTrinh { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Lấy chuỗi kết nối từ App.config giống hướng dẫn [cite: 237]
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLDACTXDConnection"].ConnectionString);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.;Initial Catalog=QLDACTXD;Integrated Security=True;TrustServerCertificate=True"
                );
            }
        }
    }
}