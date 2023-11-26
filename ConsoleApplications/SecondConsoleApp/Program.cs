using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsShoppingApp;

namespace SecondConsoleApp
{

    public class Student
    {
        int Id;
        public int StudentId { 
            get 
            {
                return Id;
            }
            set 
            { 
                if(value > 100) {
                    Console.WriteLine("Less than 100 is restricted...");
                }
                else
                {
                    Id = value; 

                }
            } 
        }

        public void ShowId()
        {
            Console.WriteLine($"Student Id : {StudentId}");
        }


        public void ForRepition()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of I : {i}");
            }
            int limit = 0;
            while(limit < 10)
            {
                Console.WriteLine($"Value of I : {limit++}");
            }
        }
    }
    public class Program
    {

        //C# built-in data type
        static void ClassBasics()
        {
            Student sutdent1 = new Student();
            Student sutdent2 = new Student();
            Student sutdent3 = new Student();
            sutdent1.StudentId = 100; //Set
            sutdent2.StudentId = 101; //Set
            sutdent3.StudentId = 103; //Set
            sutdent1.ShowId();
            sutdent2.ShowId();
            sutdent3.ShowId();

            var k = sutdent1.StudentId;

            sutdent1.ForRepition();


            Console.WriteLine(k);
             
            Console.ReadKey();
        }
        public static void DisplayDataType()
        {
            Console.WriteLine($"Size of int : {sizeof(int)} Bytes");
            Console.WriteLine($"Size of uint : {sizeof(uint)} Bytes");
            Console.WriteLine($"Size of long : {sizeof(long)} Bytes");
            Console.WriteLine($"Size of ulong : {sizeof(ulong)} Bytes");
            Console.WriteLine($"Size of float : {sizeof(float)} Bytes");
            Console.WriteLine($"Size of decimal : {sizeof(decimal)} Bytes");
            Console.WriteLine($"Size of char : {sizeof(char)} Bytes");
            Console.WriteLine($"Size of float : {sizeof(float)} Bytes");
            Console.WriteLine($"Size of byte : {sizeof(byte)} Bytes");
            Console.WriteLine($"Size of sbyte : {sizeof(sbyte)} Bytes");
            long price = -21474836482;
            Console.WriteLine(price);
        }

        public static void Main(string[] args)
        {
            //DisplayDataType();
            //MidtermExam midtermExam = new MidtermExam();
            //midtermExam.MidtermQuestion1();

            ArithmeticDemo amd = new ArithmeticDemo();
            amd.Execute();
            Console.ReadKey();
        }

    }
}
