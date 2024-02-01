using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using MVCCRDU.Models;
using PagedList;
using PagedList.Mvc;

namespace MVCCRDU.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Datacontext db = new Datacontext();
        public ActionResult Index(string Search,string Sort)
        {
            List<Employees> employees = new List<Employees>();
            if(string.IsNullOrEmpty(Search))
            {
                employees = db.employees.ToList(); 
            }
            else
            {
                employees = db.employees.Where(x => x.Name.Contains(Search)).ToList();
            }
            if(string.IsNullOrEmpty(Sort))
            {
                employees=employees.OrderBy(emp=>emp.Name).ToList();
                ViewBag.Sort = "desc";
            }
            else
            {
                employees = employees.OrderByDescending(emp => emp.Name).ToList();
                ViewBag.Sort = "";

            }
           
            return View(employees.ToPagedList(1,4));
        }
        [HttpGet]
        public ActionResult Create()
        {
            Employees employees = new Employees();
            db.employees.Add(employees);
 
            return View();

        }
        [HttpPost]
        public ActionResult Create(Employees employees)
        {
            if(ModelState.IsValid)
            {
                db.employees.Add(employees);
                db.SaveChanges();
                Response.Redirect("Index");
            }

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Employees emp = new Employees();
            emp = db.employees.Find(Id);
            return View(emp);

        }
        [HttpPost]
        public ActionResult Edit(Employees emp)
        {

            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Employees emp = new Employees();
            emp = db.employees.Find(Id);
            return View(emp);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult PostDelete(int  Id)
        {
            Employees emp= db.employees.Find(Id);

            db.employees.Remove(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            Employees emp = db.employees.Find(Id);
           
            return View(emp);

        }


    }
}