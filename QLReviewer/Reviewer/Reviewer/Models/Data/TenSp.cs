using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class TenSp
    {
        public TenSp()
        {
            BaiViet = new HashSet<BaiViet>();
        }

        public int MaTen { get; set; }
        public string TenSp1 { get; set; }
        public int? MaHsx { get; set; }
        public bool? TinhTrang { get; set; }

        public virtual HangSx MaHsxNavigation { get; set; }
        public virtual ICollection<BaiViet> BaiViet { get; set; }
    }
}
