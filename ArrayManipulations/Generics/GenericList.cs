using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulations.Generics
{
    internal class GenericList
    {
        public static void Mainxx(string[] args)
        {
            //Student aamir = new Student() { Id = 100, FullName = "Aamir" };
            //Student sara = new Student() { Id = 101, FullName = "Sara" };
            //var adil = new Student() { Id = 102, FullName = "Adil" };

            //List<Student> students = new List<Student>() { aamir, sara, adil};
            
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "Aamir");
            dic.Add(1, "Sara");
            dic.Add(2, "Sabrina");
            

            List<Student> students = new List<Student>() 
            {
                new Student() { Id = 100, FullName = "Aamir" },
                new Student() { Id = 101, FullName = "Sara" },
                new Student() { Id = 102, FullName = "Adil" }
            };

            students.Add(students[0]);
            dic.Add(4, students[0].FullName);

            foreach (KeyValuePair<int, string> kvp in dic) 
            {
                Console.WriteLine("key = {0}, value = {1}", kvp.Key, kvp.Value);
                //Console.WriteLine(kvp.Value);
            }

            //var studentCollection = new List<Student> { aamir, sara, adil };
            
            students.AddRange(students);

            foreach (var s in students)
            {
                Console.WriteLine($"Id : {s.Id}");
                Console.WriteLine($"Name : {s.FullName}");
            }


            List<string> names = new List<string>();
            
            names.Add("aamir");
            names.Add("sara");
            names.Add("Noor");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            List<int> marks = new List<int>();

            marks.Add(10);
            marks.Add(15);
            
            Console.WriteLine(marks.Count());

            foreach (var item in marks)
            {
                Console.Write($"{item},  ");
            }
            Console.WriteLine();
            
            int m = marks[0];
            
            marks.Remove(m);

            Console.WriteLine(marks.Count());

            names.Add("Mlaika");


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }

    }
}
