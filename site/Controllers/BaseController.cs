using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Parts.Data;

namespace Site.Controllers {
    public abstract class BaseController : Controller {
        protected IDbContext context;

        public BaseController(IDbContext context) {
            if (context == null) {
                throw new ArgumentNullException("dbContext");
            }

            this.context = context;
        }
    }
}
