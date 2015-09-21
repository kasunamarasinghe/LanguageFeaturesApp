﻿using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {

            return "Navigate to a URL to show an example";

        }
        public ViewResult AutoProperty()
        {

            // create a new Product object 

            Product myProduct = new Product();

            // set the property value 

            myProduct.Name = "Food";

            // get the property 

            string productName = myProduct.Name;

            // generate the view 

            return View("Result",(object)String.Format("Product name: {0}", productName));

        }

    }
}
