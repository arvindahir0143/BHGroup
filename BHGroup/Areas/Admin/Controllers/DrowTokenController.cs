using BHGroupBAL;
using BHGroupEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHGroup.Areas.Admin.Controllers
{
    public class DrowTokenController : Controller
    {
        //
        // GET: /Admin/DrowToken/

        public ActionResult Index()
        {
            return View();
        }

        public string GetGridData(GridSettings grid)
        {
            try
            {
                return new DrowTokenBAL().GetGridData(grid);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
