﻿using EFCodeFirst.Data;
using EFCodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace EFCodeFirst
{
    public class DatabaseManager
    {
        public SalesContext DB { get; set; } = new SalesContext();
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
    public class SalesCrudManager : DatabaseManager
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
        delegate void Printer();
        static void Main(string[] args)
        {
            var dbManager = new SalesCrudManager();
            //dbManager.Delete();
            //dbManager.Create();
            //dbManager.Insert(new Student { FullName = "Eman Mazari", Email = "eman.mazari@yahoo.com" });
            //dbManager.InsertInitialData();
            //dbManager.Update(2, new Student { FullName = "Rashida Bano", Email = "rashida.bano@yahoo.com" });
            //dbManager.ShowData();

            var repositoryDemo = new RepositoryDemo();
            repositoryDemo.ExecuteDemo();

            Console.ReadKey();
        }
    }
}
