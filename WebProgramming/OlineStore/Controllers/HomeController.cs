using OnlineStore.Extensions;
using OnlineStore.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

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
            //var filterd = from s in students
            //              where s.StudentId < 5
            //              select s;

            //var filter2 = students.Where(s => s.StudentId < 4).ToList();
        
            return View(students);
        }


        //Student Action Methods
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
            if (ModelState.IsValid)
            {
                dbContext.Students.Add(student);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("student/edit/{id:int}")]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                //var student = dbContext.Students.FirstOrDefault(s=> s.StudentId == id);
                var student = dbContext.Students.Find(id);

                //Only purpose is to testing the edit view  
                student.AddDefaultCourses();

                return View(student);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("student/edit")]
        public ActionResult Edit(Student student) 
        {
            if (ModelState.IsValid)
            {
                if (student == null) return View();
                dbContext.Entry(student).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
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
            if (ModelState.IsValid)
            {
                var toBeRemovedStudent = dbContext.Students.Find(student.StudentId);
                if (toBeRemovedStudent != null)
                {
                    dbContext.Students.Remove(toBeRemovedStudent);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.Conflict);
        }

        //Course Action Methods
        [HttpGet]
        [Route("course/edit/{studentId:int}/{courseId:int}")]
        public ActionResult EditCourse(int studentId, int courseId)
        {
            var student = dbContext.Students.Find(studentId);
            student.AddDefaultCourses();
            
            var course = student.Courses.FirstOrDefault(c => c.CourseId == courseId);

            course.Student = student;

            return View(course);
        }

        [HttpPost]
        [Route("course/edit")]
        public ActionResult EditCourse(Course course)
        {
            //if(ModelState.IsValid)
            //{
            //    dbContext.Entry(course).State = System.Data.Entity.EntityState.Modified;
            //    dbContext.SaveChanges();
            //}
            //return RedirectToRoute(new {controller="home", action="Edit" });
            
            return Redirect("/student/edit/1");
        }

        [HttpGet]
        [Route("course/delete/{id:int}")]
        public ActionResult DeleteCourse()
        {
            return Content("<h2>The Delete Action Method is not implemented</h2>");
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