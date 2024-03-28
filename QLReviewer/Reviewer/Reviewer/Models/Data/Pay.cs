using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class Pay
    {
        public int IdPay { get; set; }
        public int? MaReviewer { get; set; }
        public string EmailNl { get; set; }
        public decimal? SoTien { get; set; }
        public bool? TinhTrang { get; set; }
        public DateTime? NgayGio { get; set; }
        public DateTime? NgayGioHoanTat { get; set; }

        public virtual Author MaReviewerNavigation { get; set; }
    }
}
