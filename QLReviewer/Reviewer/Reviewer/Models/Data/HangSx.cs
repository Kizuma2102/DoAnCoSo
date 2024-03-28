using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class HangSx
    {
        public HangSx()
        {
            TenSp = new HashSet<TenSp>();
        }

        public int MaHsx { get; set; }
        public string TenHang { get; set; }
        public int? MaLoai { get; set; }

        public virtual LoaiSp MaLoaiNavigation { get; set; }
        public virtual ICollection<TenSp> TenSp { get; set; }
    }
}
