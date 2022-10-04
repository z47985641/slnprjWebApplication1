﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjWebApplication1.ViewModels;
using prjWebApplication1.Models;
using prjWebApplication1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjWebApplication1.Controllers
{
    public class MemberCreateController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Member member)
        {
            MingSuContext db = new MingSuContext();
            db.Members.Add(member);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(CLoginViewModel vModel)
        {
            Member cust = (new MingSuContext()).Members.FirstOrDefault(c => c.MemberAccount.Equals(vModel.txtAccount));
            if (cust != null)
            {
                if (cust.MemberPassword.Equals(vModel.txtPassword))
                {
                    string jsonUser = JsonSerializer.Serialize(cust);
                    HttpContext.Session.SetString("KK", jsonUser);
                    ViewBag.check = true;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
