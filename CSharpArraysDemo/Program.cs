using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysDemo
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            SingleDimensionArrayDemo();
            Console.ReadKey();
        }

        static void SingleDimensionArrayDemo()
        {
            int k = 90;
            try
            {
                int x = 0;
                //Method - 1
                int[] Marks;
                Marks = new int[6];
                Marks[0] = 11;
                Marks[1] = 12;
                Marks[2] = 13;
                Marks[3] = 14;
                Marks[4] = 15;
                Marks[5] = 150;

                DisplayArray(Marks);

                //Method - 2
                //int[] Marks = { 10, 20, 30, 100, 200};

                //int[] Marks = new int[] { 10, 20, 30, 100, 200, 100, 89, 90 };

                //int[,] coins = { {1,2}, {2,3} };


                //Console.WriteLine($"Marks[0] = {Marks[0]}");
                //Console.WriteLine($"Marks[1] = {Marks[1]}");
                //Console.WriteLine($"Marks[2] = {Marks[2]}");
                //Console.WriteLine($"Marks[3] = {Marks[3]}");
            }
            catch( Exception ex )  
            {
                Console.WriteLine($"{ex.StackTrace}");
            }
           
            k = 00;
            Console.ReadLine();
        }

        public static void DisplayArray(int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.WriteLine($"Marks : {mark}");
            }
        }
    }
}
