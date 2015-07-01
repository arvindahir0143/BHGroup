using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BHGroup.Areas.Admin.ViewModels;
using WebMatrix.WebData;
using BHGroupBAL;
using BHGroupEntity;

namespace BHGroup.Areas.Admin.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {


        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (HttpContext.Session != null)
                        HttpContext.Session.Abandon();

                    AdminBAL _AdminBAL = new AdminBAL();
                    var user = _AdminBAL.ValidUser();

                    if (user != null)
                    {
                        if (ModelState.IsValid && (model.Password == user.Password))
                        {
                            FormsAuthentication.SetAuthCookie("Admin", false);
                            FormsAuthenticationTicket formsAuthenticationTicket = new FormsAuthenticationTicket("Admin", false, 240);
                            HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(formsAuthenticationTicket));
                            Response.Cookies.Add(httpCookie);

                            if (Request.QueryString["ReturnUrl"] == null)
                                return RedirectToAction("Index", "Dashboard");
                            else
                                return Redirect(Request.QueryString["ReturnUrl"]);
                        }
                        else
                        {
                            TempData["errormsg"] = "The email or password provided is incorrect";
                        }
                    }
                    else
                    {
                        TempData["errormsg"] = "Admin Does Not Exist";
                    }
                }
            }
            catch (Exception ex)
            {

                TempData["errormsg"] = ex.Message;
            }
            return View(model);

        }

        public ActionResult SignOut()
        {

            try
            {
                FormsAuthentication.SignOut();
            }
            catch (Exception)
            {

                throw;
            }
            return Redirect("Login");
        }

    }
}
