
using System;
using ArrayManipulations;
using ArrayManipulations.Exams;

namespace ArrayManipulations
{
    public class Program
    {
        static void Mainxx(string[] args)
        {
            //Console.WriteLine("Hello Wrold");
            int [] dataStore = new int[] { 10, 20, 13, 14, 50, 58 };
            
            ArrayManipulation studentMarks = new ArrayManipulation(dataStore);
            
            studentMarks.DisplayArrayData();
            
            studentMarks.ChangeArrayElementValue(2, 999);

            studentMarks.DisplayArrayData();


            //Update Marks
            UpdateMarks u = new UpdateMarks(dataStore);
            //u.Marks = dataStore;
            u.UpdateStudentMarks(3, 98);

            studentMarks.DisplayArrayData();

            Console.WriteLine("\n");

            int[] marks = new int[] { 10, 20, 13, 14, 50, 58 };
            string[] students = { "aamir", "sara", "noor", "adil"};
            float [] earthQuikMagnitudes = { 4.2f, 5.6f, 6.4f, 7.62f, 8.5f };
            
            u.GeneralArrayPrint(marks);
            u.GeneralArrayPrint(students);
            u.GeneralArrayPrint(earthQuikMagnitudes);
            
            Console.ReadLine();
        }
    }
}
