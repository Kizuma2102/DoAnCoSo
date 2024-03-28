using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class TinHeaderViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public TinHeaderViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        private List<BaiViet> LayTin(int count)
        {
            return db.BaiViet.OrderBy(a => a.NgayViet).Where(a => a.TinhTrang == true).Take(count).ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tin = LayTin(2);
            return View(tin);
        }
    }
}
