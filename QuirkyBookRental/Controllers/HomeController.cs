﻿using QuirkyBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuirkyBookRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db; 

        public HomeController()
        {
            _db = new ApplicationDbContext(); 
        }
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}