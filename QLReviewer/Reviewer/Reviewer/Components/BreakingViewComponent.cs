using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class BreakingViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public BreakingViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await db.BaiViet.ToListAsync());
        }
    }
}
