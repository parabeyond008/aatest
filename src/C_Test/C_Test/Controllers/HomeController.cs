using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace C_Test
{  

    public class HomeController : Controller
    {


        public HomeController()
        {
        }


        public  IActionResult Index()
        {
            ViewBag.SystemName = "我就是的";
            return View();
        }

        [HttpPost]
        public IActionResult Save()
        {
            return Content("保存成功");
        }

        public IActionResult Info()
        {
            return View();
        }

    }
}

