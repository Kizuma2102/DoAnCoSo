using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class ChuyenMuc
    {
        public ChuyenMuc()
        {
            LoaiSp = new HashSet<LoaiSp>();
        }

        public int MaMuc { get; set; }
        public string TenMuc { get; set; }
        public string HinhChuyenMuc { get; set; }

        public virtual ICollection<LoaiSp> LoaiSp { get; set; }
    }
}
