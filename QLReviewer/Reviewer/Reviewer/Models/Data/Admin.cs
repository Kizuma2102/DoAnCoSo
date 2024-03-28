using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class Admin
    {
        public int MaAdmin { get; set; }
        public string UsernameAd { get; set; }
        public string PasswordAd { get; set; }
        public string FullnameAd { get; set; }
        public string EmailAd { get; set; }
        public string AvatarAd { get; set; }
        public int? IsAdmin { get; set; }
        public int? Allowed { get; set; }
    }
}
