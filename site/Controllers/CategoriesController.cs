using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Parts.Data;
using Boilerplate.DAL;

namespace Site.Controllers {
    public class CategoriesController : BaseController {
        public CategoriesController(IDbContext context)
            : base(context) {
        }

        public ActionResult Index() {
            return View(context.Set<Category>().ToList());
        }
    }
}
