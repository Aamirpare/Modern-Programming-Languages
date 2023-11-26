using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DBManagmentSalesEntities();

            var students = db.Students;

            //Add student to the database
            //var newStudent = new Student
            //{
            //    Id = 7,
            //    FullName = "Syeda Kulsoom",
            //    Email = "s.kulsomm@gmail.com"
            //};

            //db.Students.Add(newStudent);
            //db.SaveChanges();


            //Show all data
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.FullName}, {student.Email}");
            }

            Console.ReadKey();
        }
    }
}
