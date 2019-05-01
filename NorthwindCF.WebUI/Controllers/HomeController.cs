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
            string musteriID = Request.Params["txt_müsteriID"];
			string musteriadi = Request.Params["txt_müsteriadi"];
			string contactTitle = Request.Params["txt_contactTitle"];
			string CompanyName = Request.Params["txt_companyName"];
			string adres = Request.Params["txt_adres"];
			string sehir= Request.Params["txt_sehir"];

			Customer customer = new Customer();
            customer.CustomerID = musteriID.Substring(0, 5).ToUpper();
			customer.ContactName = musteriadi;
			customer.ContactTitle = contactTitle;
			customer.CompanyName = CompanyName;
			customer.Address = adres;
			customer.City = sehir;
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