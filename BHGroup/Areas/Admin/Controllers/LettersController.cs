using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BHGroupBAL;
using BHGroupEntity;
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

        public ActionResult Index(int? id = null)
        {
            LetterModel model = new LetterModel();
            if (id != 0 && id!= null)
            {
                Member oMember = new MemberBAL().GetById(id.Value);
                PloatBooking oPloat = new PloatBookingBAL().GetById(id.Value);
                model.Name = oMember.Name;
                model.Address = oMember.Address;
                model.phoneno = oMember.PhoneNo_Office;
                model.plottype = oPloat.PloatType;
                model.PlotDesc = oPloat.PlotDesc;
                model.StartDate = oPloat.StartDate;
            }
            ViewBag.MemberLookUp = new MemberBAL().GetAllMemberLookUp();
            return View(model);
        }

        public ActionResult CommitmentLetter(int? id = null)
        {
            LetterModel model = new LetterModel();
            if (id != 0 && id != null)
            {
                Member oMember = new MemberBAL().GetById(id.Value);
                PloatBooking oPloat = new PloatBookingBAL().GetById(id.Value);
                model.Name = oMember.Name;
                model.Address = oMember.Address;
                model.phoneno = oMember.PhoneNo_Office;
                model.plottype = oPloat.PloatType;
                model.PlotDesc = oPloat.PlotDesc;
                model.StartDate = oPloat.StartDate;
            }
            ViewBag.MemberLookUp = new MemberBAL().GetAllMemberLookUp();
            return View(model);
        }
    }
}
