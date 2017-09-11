using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEmailSendGrid.SendEmail;

namespace WebEmailSendGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Sendgrid sendGrid = new Sendgrid();
            //sendGrid.Execute();

            Sendinblue sendBlue = new Sendinblue();
            sendBlue.Send();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}