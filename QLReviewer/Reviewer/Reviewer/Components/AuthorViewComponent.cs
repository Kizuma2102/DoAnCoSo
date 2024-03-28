using Microsoft.AspNetCore.Mvc;
using Reviewer.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviewer.Components
{
    public class AuthorViewComponent: ViewComponent
    {
        private readonly ReviewSPContext db;
        public AuthorViewComponent(ReviewSPContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke(int? id)
        {
            var bvtg = from l in db.Author
                       where l.MaReviewer == id
                       select l;
            return View(bvtg);
        }
    }
}
