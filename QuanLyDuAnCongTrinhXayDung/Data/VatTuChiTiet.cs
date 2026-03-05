namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class VatTuChiTiet
    {
        public int ID { get; set; } 
        public int DuAnID { get; set; } 
        public int VatTuID { get; set; } 
        public double SoLuong { get; set; } 
        public decimal DonGiaTaiThoiDiem { get; set; } 
        public DateTime NgayCapPhat { get; set; } 
        public string? HinhAnh { get; set; }

        public virtual DuAn DuAn { get; set; } = null!; 
        public virtual VatTu VatTu { get; set; } = null!; 
    }
}