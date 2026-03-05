using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class LoaiDuAn
    {
        public int ID { get; set; }
        [Required, MaxLength(100)]
        public string TenLoai { get; set; }
        public virtual ObservableCollectionListSource<DuAn> DuAn { get; } = new();
    }
}
