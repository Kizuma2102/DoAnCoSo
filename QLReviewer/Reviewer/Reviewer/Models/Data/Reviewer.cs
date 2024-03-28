using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class Reviewer
    {
        public Reviewer()
        {
            BaiViet = new HashSet<BaiViet>();
            Pay = new HashSet<Pay>();
        }

        public int MaReviewer { get; set; }
        public string UsernameRe { get; set; }
        public string PasswordRe { get; set; }
        public string FullnameRe { get; set; }
        public string EmailRe { get; set; }
        public string AvatarRe { get; set; }
        public string DiaChiRe { get; set; }
        public decimal? SoTien { get; set; }

        public virtual ICollection<BaiViet> BaiViet { get; set; }
        public virtual ICollection<Pay> Pay { get; set; }
    }
}
