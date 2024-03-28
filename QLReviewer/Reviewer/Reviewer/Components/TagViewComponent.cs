using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class TagViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public TagViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke(int id)
        {
            var tag = from l in db.Tag select l;
            return View(tag);
        }
    }
}
