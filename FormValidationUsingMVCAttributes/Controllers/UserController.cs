using FormValidationUsingMVCAttributes.Models;
using System;
using System.Web.Mvc;

namespace FormValidationUsingMVCAttributes.Controllers
{
    public class UserController : Controller
    {
        //Validation code for DOB field which is called using Remote Attribute
        public JsonResult IsValidDate(DateTime DOB)
        {
            bool Status;
            if (DOB > DateTime.Now.AddYears(-18))
                Status = false;
            else
                Status = true;
            return Json(Status, JsonRequestBehavior.AllowGet);
        }
        public ViewResult AddUser()
        {
            return View();
        }
        public ViewResult DisplayUser(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("AddUser", user);
            }

        }
    }
}