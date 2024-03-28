using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class BVPhoBienViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public BVPhoBienViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        private List<BaiViet> LayBV(int count)
        {
            return db.BaiViet.OrderByDescending(a => a.TenBai).Where(a => a.TinhTrang == true).Take(count).ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tinmoi = LayBV(3);
            return View(tinmoi);
        }
    }
}
