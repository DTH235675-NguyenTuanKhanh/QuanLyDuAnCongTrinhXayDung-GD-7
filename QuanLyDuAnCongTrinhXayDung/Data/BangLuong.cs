namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class BangLuong
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; } // Khóa ngoại [cite: 174]
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int SoNgayCong { get; set; }
        public decimal TongPhuCap { get; set; } // Tổng phụ cấp từ các dự án tham gia
        public decimal ThucLinh { get; set; } // (LuongCoBan * SoNgayCong) + TongPhuCap

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}