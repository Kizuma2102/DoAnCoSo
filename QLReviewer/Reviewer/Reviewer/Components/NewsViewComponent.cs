using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class NewsViewComponent : ViewComponent
    {
        private readonly ReviewSPContext db;
        public NewsViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        private List<BaiViet> LayTinMoi(int count)
        {
            return db.BaiViet.OrderByDescending(a => a.NgayViet).Where(a => a.TinhTrang == true).Take(count).ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tinmoi = LayTinMoi(3);
            return View(tinmoi);
        }
    }
}
