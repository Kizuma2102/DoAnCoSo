using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class XemNhieuViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public XemNhieuViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        private List<BaiViet> LayTin(int count)
        {
            return db.BaiViet.OrderByDescending(a => a.LuotXem).Where(a => a.TinhTrang == true).Take(count).ToList();
        }
        Random rd = new Random();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int count = db.LoaiSp.Count();
            int ar = rd.Next(1, count);
            var tinxemnhieu = db.BaiViet.OrderByDescending(a => a.MaBai == ar).Take(5).ToList();
            return View(tinxemnhieu);
        }
    }
}
