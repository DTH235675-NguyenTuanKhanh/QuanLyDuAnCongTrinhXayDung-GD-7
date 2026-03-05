using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class NhatKyCongTrinh
    {
        public int ID { get; set; }
        public int DuAnID { get; set; }
        public DateTime NgayGhi { get; set; } = DateTime.Now;
        [Required]
        public string NoiDungCongViec { get; set; } = null!;
        public string? GhiChu { get; set; } // Ví dụ: Thời tiết xấu, thiếu vật tư

        public virtual DuAn DuAn { get; set; } = null!;
    }
}
