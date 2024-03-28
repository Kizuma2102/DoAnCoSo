using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class Tag
    {
        public Tag()
        {
            BaiViet = new HashSet<BaiViet>();
            PostBv = new HashSet<PostBv>();
        }

        public int MaTag { get; set; }
        public string TenTag { get; set; }

        public virtual ICollection<BaiViet> BaiViet { get; set; }
        public virtual ICollection<PostBv> PostBv { get; set; }
    }
}
