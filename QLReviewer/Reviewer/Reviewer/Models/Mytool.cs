using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public class Mytool
    {
        public static string UploadHinh(IFormFile fHinh, string folder)
        {
            string fileNameReturn = string.Empty;
            if (fHinh != null)
            {
                fileNameReturn = $"_{DateTime.Now.Ticks}{fHinh.FileName}";
                var fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", folder, fileNameReturn);
                using (var file = new FileStream(fileName, FileMode.Create))
                {
                    fHinh.CopyTo(file);
                }
            }
            return fileNameReturn;
        }
    }
    public static class StaticClass
    {
        public static string ToUrlFriendly(this string url)
        {
            url = url.ToLower();

            //Lọc bỏ từ tiếng Việt
            url = Regex.Replace(url, @"[áàạảãâấầậẩẫăắằặẳẵ]", "a");
            url = Regex.Replace(url, @"[éèẹẻẽêếềệểễ]", "e");
            url = Regex.Replace(url, @"[óòọỏõôốồộổỗơớờợởỡ]", "o");
            url = Regex.Replace(url, @"[úùụủũưứừựửữ]", "u");
            url = Regex.Replace(url, @"[íìịỉĩ]", "i");
            url = Regex.Replace(url, @"đ", "d");
            url = Regex.Replace(url, @"[ýỳỵỷỹ]", "y");

            //thay thế theo chuẩn URL friendly
            url = Regex.Replace(url, @"[^a-z0-9\s-]", "");
            url = Regex.Replace(url, @"\s+", "-");
            url = Regex.Replace(url, @"\s", "-");

            return url;
        }
    }
}
