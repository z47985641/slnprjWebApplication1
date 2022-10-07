using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult List(CKeywordViewModel model)
        {
            MingSuContext db = new MingSuContext();
            List<CAllViewModel> cAlls = new List<CAllViewModel>();

            //var rooms = db.Rooms.Select(i => i);
            //var image = db.Images.Select(i => i);
            //var member = db.Members.Select(i => i);
            //var RoomStatus = db.RoomStatuses.Select(i => i);
            //var rooms = (from r in db.Rooms
            //             join i in db.ImageReferences on r.RoomId equals i.RoomId
            //             join k in db.Images on i.ImageId equals k.ImageId
            //             join m in db.Members on r.MemberId equals m.MemberId
            //             join l in db.RoomStatuses on r.RoomstatusId equals l.RoomstatusId
            //             select new
            //             {
            //                 r.RoomName,
            //                 r.RoomPrice,
            //                 r.RoomIntrodution,
            //                 m.MemberAccount,
            //                 r.Roomstatus,
            //                 r.ImageReferences,
            //                 r.CreateDate
            //             }).ToList();

            //foreach (var i in rooms)
            //{
            //    CAllViewModel x = new CAllViewModel();
            //    x.room = i;
            //    cAlls.Add(x);
            //}



            var q = from r in db.Rooms
                    select r;
            IEnumerable<Room> datas = null;
            if (string.IsNullOrEmpty(model.txtKeyWord))

                datas = from r in db.Rooms
                        join i in db.ImageReferences on r.RoomId equals i.RoomId
                        join k in db.Images on i.ImageId equals k.ImageId
                        join m in db.Members on r.MemberId equals m.MemberId
                        join l in db.RoomStatuses on r.RoomstatusId equals l.RoomstatusId
                        select r;
            else
                datas = db.Rooms.Where(p => p.RoomName.Contains(model.txtKeyWord)
                || p.RoomPrice.ToString().Contains(model.txtKeyWord)
                || p.RoomIntrodution.Contains(model.txtKeyWord)
                || p.MemberId.ToString().Contains(model.txtKeyWord)
                || p.RoomstatusId.ToString().Contains(model.txtKeyWord)
                || p.Address.Contains(model.txtKeyWord)
                || p.CreateDate.ToString().Contains(model.txtKeyWord));
            return View(cAlls);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Room p)
        {
            MingSuContext db = new MingSuContext();
            db.Rooms.Add(p);
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
                Room r = db.Rooms.FirstOrDefault(t => t.RoomId == id);
                if (r != null)
                    return View(r);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public ActionResult Edit(CRoomViewModel InRoom)
        {
            MingSuContext db = new MingSuContext();
            Room r = db.Rooms.FirstOrDefault(t => t.RoomId == InRoom.RoomId);
            if (r != null)
            {
                //if (InRoom.photo != null)
                //{
                //    string pName = Guid.NewGuid().ToString() + ".jpg";
                //    r.FImagePath = pName;
                //    string path = _enviro.WebRootPath + "/images/" + pName;
                //    InRoom.photo.CopyTo(new FileStream(path, FileMode.Create));
                //}
                r.RoomId = InRoom.RoomId;
                r.RoomName = InRoom.RoomName;
                r.RoomPrice = InRoom.RoomPrice;
                r.RoomIntrodution = InRoom.RoomIntrodution;
                r.MemberId = InRoom.MemberId;
                r.RoomstatusId = InRoom.RoomstatusId;
                r.Address = InRoom.Address;
                r.CreateDate = InRoom.CreateDate;

                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
