﻿using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    public class ProductController : Controller
    {

       
        public IActionResult Index()
        {
            return View();
        }
    }
}

