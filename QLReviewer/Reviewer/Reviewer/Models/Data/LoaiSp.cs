using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            BaiViet = new HashSet<BaiViet>();
            PostBv = new HashSet<PostBv>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int? MaMuc { get; set; }

        public virtual ChuyenMuc MaMucNavigation { get; set; }
        public virtual ICollection<BaiViet> BaiViet { get; set; }
        public virtual ICollection<PostBv> PostBv { get; set; }
    }
}
