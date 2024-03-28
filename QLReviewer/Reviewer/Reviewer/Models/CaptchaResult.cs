using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class CaptchaResult
    {
        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }
        public byte[] CaptchaByteData { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
