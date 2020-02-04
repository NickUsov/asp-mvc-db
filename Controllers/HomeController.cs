using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
using System.Data.Entity;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QuestRoomContext db = new QuestRoomContext();
        public ActionResult Index()
        {
            return View(db.QuestRooms);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(QuestRoom room)
        {
            db.QuestRooms.Add(room);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            QuestRoom room = db.QuestRooms.Find(id);
            if (room != null)
            {
                return View(room);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(QuestRoom room)
        {
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var room = db.QuestRooms.Find(id);
            if (room != null)
                return View(room);
            else
                return new HttpNotFoundResult("Quest room doesn't exist");
        }
        public ActionResult Delete(int id)
        {
            QuestRoom r = db.QuestRooms.Find(id);
            if (r != null)
            {
                db.QuestRooms.Remove(r);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}