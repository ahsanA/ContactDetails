using ContactDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ContactDetails.Controllers
{
    public class PersonController : Controller
    {

        private ContactEntities db = new ContactEntities();

        // GET: Person
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact model)
        {
            db.Contacts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditContact(int id)
        {
            var contact = db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact(Contact model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var contact =  db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}