using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using Reviewer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class SubMenuViewComponent:ViewComponent
    {
        private readonly ReviewSPContext db;
        public SubMenuViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke(int id)
        {
            var submenu = from l in db.LoaiSp
                          where l.MaMuc == id
                          select l;
            return View(submenu);
        }
    }
}
