using OnlineStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    //How to pass data to the views
    public class HomeController : Controller
    {
        SalesContext dbContext = new SalesContext();

        [HttpGet]
        public ActionResult Index()
        {
            //var products = StaticDataStore.GetAll();
            //var products = StaticDataStore.CreateDummyProduct(150);

            //return View(products);

            var students = dbContext.Students.ToList();
            
            return View(students);
        }

        [HttpGet]
        [Route("student/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("student/create")]
        public ActionResult Create(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("student/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var student = dbContext.Students.FirstOrDefault(s=> s.StudentId == id);
                return View(student);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("student/edit")]
        public ActionResult Edit(Student student) 
        {
            if(student == null) return View();
            dbContext.Entry(student).State = System.Data.Entity.EntityState.Modified; 
            dbContext.SaveChanges(); 
            return RedirectToAction("Index");    
        }

        [HttpGet]
        [Route("student/delete/{id}")]
        public ActionResult Delete(int id)
        {
            var student = dbContext.Students.FirstOrDefault(s => s.StudentId == id);
            return View(student);
        }
        [HttpPost]
        [Route("student/delete")]
        public ActionResult Delete(Student student)
        {
            var toBeRemovedStudent = dbContext.Students.Find(student.StudentId);
            if(toBeRemovedStudent != null)
            {
                dbContext.Students.Remove(toBeRemovedStudent);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.Conflict);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("TopSellingItems")]
        public ActionResult TopSellingProducts()
        {
            return Content($"Top Selling Items");
        }
        public ActionResult ProductionByYear(int year, int month)
        {
            var content = string.Format("Production Year: {0}/{1}", year, month);
            return Content(content);
        }
    }
}