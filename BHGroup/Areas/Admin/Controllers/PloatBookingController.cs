using BHGroup.Areas.Admin.ViewModels;
using BHGroupBAL;
using BHGroupEntity;
using BHGroupEntity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BHGroup.Areas.Admin.Controllers
{
    public class PloatBookingController : Controller
    {
        //
        // GET: /Admin/PloatBooking/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Manage(int? id)
        {
            PloatBooking model = new PloatBooking();
            ViewBag.MemberLookUp = new MemberBAL().GetMemberLookUp();
            if (id != 0 && id != null)
            {
                model = new PloatBookingBAL().GetById(id.Value);
            }

            return PartialView(model);
        }
        public JsonResult Save(PloatBooking model)
        {
            try
            {
                //model.CreatOn = DateTime.Now;
                bool Add_Flag = new PloatBookingBAL().isNewEntry(model.PloatBookingId);
                if (Add_Flag)
                    new PloatBookingBAL().Create(model);
                else
                    new PloatBookingBAL().Update(model);

                return Json(new { success = true, message = CommonMsg.Success(EntityNames.PloatBooking, (Add_Flag == true ? En_CRUD.Insert : En_CRUD.Update)) });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = CommonMsg.Fail(EntityNames.PloatBooking, En_CRUD.Update) });
            }
        }

        public string GetGridData(GridSettings grid)
        {
            try
            {
                return new PloatBookingBAL().GetGridData(grid);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public JsonResult Delete(int id = 0)
        {
            try
            {
                new PloatBookingBAL().Delete(id);
                return Json(new { success = true, message = CommonMsg.Success(EntityNames.PloatBooking, En_CRUD.Delete) });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = CommonMsg.Fail(EntityNames.PloatBooking, En_CRUD.Delete) });
            }
        }

    }
}
