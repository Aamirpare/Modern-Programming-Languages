using EntityFramworkDemo.ModelFirstApproach;
using System;

namespace EntityFramworkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var DbContext = new DBManagmentSalesEntities();
            
            foreach (var item in DbContext.Students)
            {
                Console.WriteLine($"Id: {item.Id}, Name : {item.FullName}");
            }

            //Insert new student record into database
            //1. create new student instance
            //2. add this newly created instance to the Students collection of DbContext
            //3. call SaveChanges on the DbContext

            //1. create new student instance
            var student = new Student
            {
                Id = 6,
                FullName = "Rahule Butt",
                Email = "rahule.butt@gmail.com"
            };
            //2. add this newly created instance to the Students collection of DbContext
            //DbContext.Students.Add(student);

            //3. call SaveChanges on the DbContext
            //DbContext.SaveChanges();

        }
    }
}
