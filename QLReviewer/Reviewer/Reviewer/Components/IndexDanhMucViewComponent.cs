using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class IndexDanhMucViewComponent:ViewComponent
    {
        private readonly ReviewSPContext db;
        public IndexDanhMucViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var danhmuc = from d in db.ChuyenMuc select d;
            return View(danhmuc);
        }
    }
}
