using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHGroup.Controllers
{
    [Authorize]
    public class MemberDashboardController : Controller
    {
        //
        // GET: /Dashboard/
        
       
        public ActionResult Index()
        {
            return View();
        }

    }
}
