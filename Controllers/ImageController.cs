using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Controllers
{
    public class ImageController : Controller
    {
        private IWebHostEnvironment _enviro;
        public ImageController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List(CKeywordViewModel model)
        {
            MingSuContext db = new MingSuContext();
            var q = from r in db.Images
                    select r;
            //IEnumerable<Image> datas = null;
            return View(q);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Image p)
        {
            MingSuContext db = new MingSuContext();
            db.Images.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                MingSuContext db = new MingSuContext();
                Room r = db.Rooms.FirstOrDefault(t => t.RoomId == id);
                if (r != null)
                {
                    db.Rooms.Remove(r);
                    db.SaveChanges();
                }

            }
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MingSuContext db = new MingSuContext();
                Image r = db.Images.FirstOrDefault(t => t.ImageId == id);
                if (r != null)
                    return View(r);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public ActionResult Edit(CImageViewModel InImage)
        {
            MingSuContext db = new MingSuContext();
            Image r = db.Images.FirstOrDefault(t => t.ImageId == InImage.ImageId);
            if (r != null)
            {
                if (InImage.photo != null)
                {
                    string iName = Guid.NewGuid().ToString() + ".jpg";
                    r.ImagePath = iName;
                    string path = _enviro.WebRootPath + "/Image/" + iName;
                    InImage.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                r.ImageId = InImage.ImageId;
                r.ImageCaption = InImage.ImageCaption;
                //r.ImagePath = InImage.ImagePath;
               
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
