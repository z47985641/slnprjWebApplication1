using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Controllers
{
    public class CustomerHome : Controller
    {
        public IActionResult Index()
        {
            MingSuContext db = new MingSuContext();
            var datas = from r in db.Rooms
                    join i in db.ImageReferences on r.RoomId equals i.RoomId
                    join k in db.Images on i.ImageId equals k.ImageId
                    join m in db.Members on r.MemberId equals m.MemberId
                    join l in db.RoomStatuses on r.RoomstatusId equals l.RoomstatusId
                    select r;
            return View(datas);
        }

    }
}
