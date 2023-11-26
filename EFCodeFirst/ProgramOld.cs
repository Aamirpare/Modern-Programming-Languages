using EFCodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCodeFirst
{
    public class Program_one
    {
        static void Main_xxx(string[] args)
        {
            SalesContext DB  = new SalesContext();
            
            //Create databse
            if (!DB.Database.Exists())
            {
                DB.Database.Create();
                Console.WriteLine("SalesManagerDB created successfully.");
            }

            //Delete database
            if (DB.Database.Delete())
            {
                Console.WriteLine("Database deleted Successfully.");
            }

            //Add Student
            var student = new Student { StudentId = 1, FullName = "Saima Khan", Email="saima.khan@yahoo.com"  };
            DB.Students.Add(student);
            if (DB.SaveChanges() > 0)
            {
                Console.WriteLine("Record Inserted Successfully.");
            }
        
            //Add many students
            var students = new List<Student>
            {
                new Student
                {
                    FullName = "Aamir Parre",
                    Email = "aamirpare@gamil.com"
                },
                new Student
                {
                    FullName = "Sonia Wajpaie",
                    Email = "sunia.wajpaie@yahoo.com"
                },
                new Student
                {
                    FullName = "Noore Sehar",
                    Email = "noore.sehar@gmail.com"
                }
            };

            DB.Students.AddRange(students);
            if (DB.SaveChanges() > 0)
            {
                Console.WriteLine("Records Inserted Successfully.");
            }
        
            //Show all students
            foreach (var s in DB.Students)
            {
                Console.WriteLine($"{s.StudentId},  {s.FullName}, {s.Email}");
            }
        
            //Update student
            var entity = DB.Students.FirstOrDefault(s => s.StudentId == 1);
        
            entity.FullName = "Noor Khan";
            entity.Email = "noor.khan@gmail.com";
            if (DB.SaveChanges() > 0)
            {
                Console.WriteLine("Record updated successfully.");
                return;
            }

            Console.WriteLine("The student to be updated is not found.");

            //Delete student
            entity = DB.Students.FirstOrDefault(s => s.StudentId == 2);
            DB.Students.Remove(entity);
            if (DB.SaveChanges() > 0)
            {
                Console.WriteLine($"{entity.FullName} is successfully deleted from the database.");
            }
            
            Console.ReadKey();
        }
    }
}
