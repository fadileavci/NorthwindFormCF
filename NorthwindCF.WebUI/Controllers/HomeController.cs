using NorthwindFormCF_BLL;
using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindCF.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }
        public ActionResult Kaydet()
        {
            string musteriadi = Request.Params["txt_müsteriadi"];
            Customer customer = new Customer();
            customer.CustomerID = musteriadi.Substring(0, 5).ToUpper();
            customer.ContactName = "fadile";
            customer.ContactTitle =  " ";
            customer.CompanyName = "";
            customer.Address = " ";
            customer.City = "istanbul";
            customer.Country = "sdfghj";
            customer.Fax = "fgh";
            customer.Phone = "fgh";
            customer.PostalCode = "bn";
            customer.Region = 1;
            CustomerBLL.AddCustomer(customer);


            return RedirectToAction("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}