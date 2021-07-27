using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Google_Auth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(string Name, string Email)
        {
            try
            {
                if (Name != "" || Name != null)
                {
                    //Create Alphanumeric token for User Verification or IDK
                    Random ran = new Random();
                    string alphanumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
                    string special_characters = "!@#$%^&*~";

                    //Set Up your own or delete it or something
                    int length = 10;
                    string random = "";

                    for (int i = 0; i < length; i++)
                    {
                        int a = ran.Next(alphanumeric.Length); 
                        random = random + alphanumeric.ElementAt(a);
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        int sz = ran.Next(special_characters.Length);
                        random = random + special_characters.ElementAt(sz);
                    }

                        if (random == "" || random == null)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            Session["token"] = random;
                            return Json(random, JsonRequestBehavior.AllowGet);
                        }                                  
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                    return new HttpStatusCodeResult(400, "Unexpected error, You might be doing something fishy");
            }
        }

        public ActionResult Landing()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}