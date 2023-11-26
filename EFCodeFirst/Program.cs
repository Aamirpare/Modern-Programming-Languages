using EFCodeFirst.Data;
using EFCodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCodeFirst
{
    public class SalesDbContext
    {
        public SalesContext DB { get; set; } = new SalesContext();
    }
    public class DatabaseManager : SalesDbContext
    {
        public void Create()
        {
            if (!DB.Database.Exists())
            {
                DB.Database.Create();
                Console.WriteLine("SalesManagerDB created successfully.");
            }
        }
        public void Delete()
        {
            if (DB.Database.Delete())
            {
                Console.WriteLine("Database deleted Successfully.");
            }
        }
    }
    public class SalesCrudManager : SalesDbContext
    {
        public void Insert(Student student)
        {
            DB.Students.Add(student);
            if (DB.SaveChanges() > 0)
            {
                Console.WriteLine("Record Inserted Successfully.");
            }
        }
        public void InsertInitialData()
        {
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
        }
        public void ShowData()
        {
            foreach (var s in DB.Students)
            {
                Console.WriteLine($"{s.StudentId},  {s.FullName}, {s.Email}");
            }
        }
        public void Update(int toBeUpdatedStudentId, Student updateWith)
        {
            var toBeUpdatedStudent = DB.Students.FirstOrDefault(s => s.StudentId == toBeUpdatedStudentId);
            if (toBeUpdatedStudent != null)
            {
                toBeUpdatedStudent.FullName = updateWith.FullName;
                toBeUpdatedStudent.Email = updateWith.Email;
                if (DB.SaveChanges() > 0)
                {
                    Console.WriteLine("Record updated successfully.");
                    return;
                }
            }
            Console.WriteLine("The student to be updated is not found.");
        }
        public void Delete(int toBeDeletedStudentId)
        {
            var toBeDeletedStudent = DB.Students.FirstOrDefault( s=> s.StudentId == toBeDeletedStudentId);
            DB.Students.Remove(toBeDeletedStudent);
            if(DB.SaveChanges() > 0)
            {
                Console.WriteLine($"{toBeDeletedStudent.FullName} is successfully deleted from the database.");
            }
            Console.WriteLine($"No operation performed.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var dbManager = new SalesCrudManager();
            //dbManager.Delete();
            //dbManager.Create();
            //dbManager.Insert(new Student { FullName = "Eman Mazari", Email = "eman.mazari@yahoo.com" });
            //dbManager.InsertMany();
            //dbManager.Update(2, new Student { FullName = "Rashida Bano", Email = "rashida.bano@yahoo.com" });
            //dbManager.ShowData();

            var repositoryDemo = new RepositoryDemo();
            repositoryDemo.ExecuteDemo();

            Console.ReadKey();
        }
    }
}
