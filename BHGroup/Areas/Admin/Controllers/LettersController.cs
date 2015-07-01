using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BHGroupBAL;
using BHGroup.Areas.Admin.ViewModels;

namespace BHGroup.Areas.Admin.Controllers
{
    public class LettersController : Controller
    {
        //
        // GET: /Admin/Letters/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WelcomeLetter()
        {
            
            ViewBag.MemberLookUp = new MemberBAL().GetAllMemberLookUp();
            return View();
        }

        public JsonResult GetCustomerDataById(int id)
        {
            LetterModel model = new LetterModel();
            var lst = new MemberBAL().GetLetterDetails(id).SingleOrDefault();
            
            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}
