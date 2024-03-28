using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class PostBv
    {
        public int MaPost { get; set; }
        public string TenBai { get; set; }
        public string HinhAnhBv { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayViet { get; set; }
        public int? MaReviewer { get; set; }
        public bool? TinhTrang { get; set; }
        public DateTime? NgayGioDuyet { get; set; }
        public int MaTag { get; set; }
        public int MaLoai { get; set; }

        public virtual LoaiSp MaLoaiNavigation { get; set; }
        public virtual Author MaReviewerNavigation { get; set; }
        public virtual Tag MaTagNavigation { get; set; }
    }
}
