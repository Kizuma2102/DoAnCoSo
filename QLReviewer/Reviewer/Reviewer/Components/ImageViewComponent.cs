using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class ImageViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public ImageViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        private List<BaiViet> SoHinh(int count)
        {
            return db.BaiViet.OrderByDescending(a => a.NgayViet).Where(a => a.TinhTrang == true).Take(count).ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var images = SoHinh(3);
            return View(images);
        }
    }
}
