using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations.Exams
{
    public class UpdateMarks
    {
        ArrayManipulation arrayManipulation;
        public int [] Marks { get; set; } 
        public UpdateMarks(int[] marks)
        {
            arrayManipulation = new ArrayManipulation(marks);
        }
        public void UpdateStudentMarks(int index, int value)
        {
            arrayManipulation.ChangeArrayElementValue(index, value);
        }

        public void GeneralArrayPrint<TElemnt>(TElemnt[] elemets)
        {
            foreach (var element in elemets)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
    }
}
