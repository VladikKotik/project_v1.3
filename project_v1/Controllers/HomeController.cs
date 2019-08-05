using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_v1.Models;
using Ninject;
using Npgsql;
using project_v1.Infrastructure;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

using Npgsql;

namespace project_v1.Controllers
{
    public class HomeController : Controller
    {

       

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Authorizing()
        {
            return View("LoginForm");
        }

        [HttpPost]
        public ViewResult Authorizing(User aut) {
            ViewBag.name = aut.Login;
            ViewBag.pswd = aut.Password;
            return View("pers", aut);

        }

        


        public IEnumerable<project_v1.Models.ICar> a_cars;
        public IAssort ass;
        public HomeController(IAssort assortparam) {
            ass = assortparam;
           
            a_cars = ass.getData();

          


        }
      

        [HttpGet]
        public ViewResult update(int lid) {
            CarsContext cont;   //update
            cont = ass.getdbcont();
            otherCar oc1 = cont.otherCars.ToList<otherCar>().Find(o => o.id == lid);
            if (oc1 == null) {
                oc1 = new otherCar();
                ass.init_car(oc1);
            }

            return View("Edit", oc1);
        }

        [HttpPost]
        public ActionResult update(otherCar loc1) {
            int locid;
            locid = loc1.id;
            //locid = 28;
            ass.update(loc1,locid);
            return RedirectToAction("configuration");
        }

        public ActionResult delete(int lid) {

           
            ass.delete(lid);
            return RedirectToAction("configuration");
        }

        

       
        public ViewResult Configuration() {
           

            return View("configInput3", ass.getdbcont());
        }

    


    }
}