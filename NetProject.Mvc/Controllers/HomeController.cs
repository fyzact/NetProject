﻿using NetProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetProject.Mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}