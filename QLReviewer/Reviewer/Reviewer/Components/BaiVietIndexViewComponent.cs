using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using Reviewer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class BaiVietIndexViewComponent:ViewComponent
    {
        private readonly ReviewSPContext db;
        public BaiVietIndexViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            CategoryNews model = new CategoryNews();
            var baiviet = (from a in db.ChuyenMuc
                           from b in db.LoaiSp
                           from c in db.BaiViet
                           where a.MaMuc == b.MaMuc && b.MaLoai == c.MaLoai && id == a.MaMuc && c.TinhTrang == true
                           select new ViewModel.CategoryNews
                           {
                               MaMuc = a.MaMuc,
                               TenBai = c.TenBai,
                               HinhAnh=c.HinhAnhBv,
                               MaBai=c.MaBai,
                               NgayViet=c.NgayViet,
                               Tag=c.MaTag
                           }).ToList();

            return View(baiviet);
        }
    }
}
