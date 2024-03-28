using Reviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.ViewModel
{
    public class CategoryNews
    {
        public int MaMuc { get; set; }
        public string TenBai { get; set; }
        public string HinhAnh { get; set; }
        public int MaBai { get; set; }
        public DateTime? NgayViet { get; set; }
        public int? Tag { get; set; }
        public string TenBvFriendly => TenBai.ToUrlFriendly();
    }
}
