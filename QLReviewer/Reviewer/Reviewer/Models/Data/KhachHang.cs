using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class KhachHang
    {
        public int MaKh { get; set; }
        public string UsernameKh { get; set; }
        public string PassKh { get; set; }
        public string HoTenKh { get; set; }
        public string EmailKh { get; set; }
        public string AvatarKh { get; set; }
    }
}
