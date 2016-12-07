using System;
using System.Linq;
using System.Web.Mvc;
using Web.Context;
using Web.Models;

namespace Web.Controllers
{
    public class TaskController : Controller
    {
        private TaskContext db = new TaskContext();

        // GET: Task
        public ActionResult Index()
        {
            var tasks = db.Tasks.ToList();
            return View(tasks);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            task.CompletedDate = new DateTime(2005, 1, 1);
            db.Tasks.Add(task);
            db.SaveChanges();

            return RedirectToAction("Index", "Task");
        }

        public ActionResult Update(int id)
        {
            var task = db.Tasks.Find(id);
            
            return View(task);
        }

        [HttpPost]
        public ActionResult Update(Task task)
        {
            var result = db.Tasks.Find(task.Id);
            if (result != null)
            {
                result.Name = task.Name;
                result.Date = task.Date;
                result.Notes = task.Notes;
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Task");
        }

        public ActionResult Delete(int id)
        {
            var result = db.Tasks.Find(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Delete(Task task)
        {
            var result = db.Tasks.Find(task.Id);
            db.Tasks.Remove(result);
            db.SaveChanges();

            return RedirectToAction("Index", "Task");
        }

        [HttpPost]
        public ActionResult MarkComplete(int id)
        {
            var result = db.Tasks.Find(id);
            if (result != null)
            {
                result.CompletedDate = DateTime.Today;
                result.IsCompleted = true;
                db.SaveChanges();
            }

            return Json(string.Empty);
        }
    }
}