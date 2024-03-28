using System;
using System.Collections.Generic;

namespace Reviewer.Models.Data
{
    public partial class Voucher
    {
        public int IdVoucher { get; set; }
        public string MaVoucher { get; set; }
        public string GiamGia { get; set; }
        public DateTime? Hsd { get; set; }
    }
}
