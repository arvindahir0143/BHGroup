//using BHGroup.Areas.Admin.Identity;
using BHGroup.Areas.Admin.ViewModels;
using BHGroupBAL;
using BHGroupEntity;
using BHGroupEntity.Classes;
using Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace BHGroup.Areas.Admin.Controllers
{

    [Authorize]
    public class MembersController : Controller
    {
        //
        // GET: /Admin/Members/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Manage(int? id)
        {
            Member model = new Member();
            model.Password = Common.GetRandomValue();
            model.MemberShipNo = Convert.ToInt32(MemberBAL.GetMembershipNo());
            ViewBag.MemberLookUp = new MemberBAL().GetMemberLookUp();
            if (id != 0 && id != null)
            {
                model = new MemberBAL().GetById(id.Value);
            }

            return View(model);
        }
        public ActionResult Save(Member model)
        {
            try
            {
                bool Add_Flag = new MemberBAL().isNewEntry(model.MemberId);
                if (Add_Flag)
                    new MemberBAL().Create(model);
                else
                    new MemberBAL().Update(model);
                string message = CommonMsg.Success(EntityNames.Member, Add_Flag == true ? En_CRUD.Insert : En_CRUD.Update);
                TempData["successmsg"] = message;
            }
            catch (Exception ex)
            {
                TempData["errormsg"] = ex.Message;
            }
            return Redirect("Index");

        }

        public JsonResult Delete(int id = 0)
        {
            try
            {
                new MemberBAL().Delete(id);
                return Json(new { success = true, message = CommonMsg.Success(EntityNames.Member, En_CRUD.Delete) });

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = CommonMsg.Fail(EntityNames.Member, En_CRUD.Delete) });
            }
        }
        public string GetGridData(GridSettings grid)
        {
            try
            {
                return new MemberBAL().GetGridData(grid);
            }
            catch (Exception ex)
            {
                return "";
            }
        }


    }
}
