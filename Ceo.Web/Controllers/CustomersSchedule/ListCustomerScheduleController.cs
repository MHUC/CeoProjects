using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ceo.Data.CustomerSchedule;
using Ceo.Web.ViewModels;

namespace Ceo.Web.Controllers.CustomersSchedule
{
    public class ListCustomerScheduleController : Controller
    {
        // GET: ListCustomerSchedule
        public ActionResult Index()
        {
            var repo = new CustomersScheduleRepository();

            var listSche = repo.GetCustomersScheduleList();

            return View(listSche);
        }

    
        public ActionResult OneoffSchedule(FormCustomerScheduleViewModel model)
        {
                return View();
        }

        [HttpPost]
        public ActionResult ListOneoffSchedule(FormCustomerScheduleViewModel model)
        {
            //var test  = model.StartDate;

            var repo = new CustomersScheduleRepository();

            var listOneoff = repo.GetOneoffSchedule(model.StartDate);

            return View(listOneoff);

        }

    }
}