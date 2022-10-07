using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.ViewModel
{
    public class CCustomerHome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
