using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations
{
    public class ArrayManipulation
    {
        private int[] DataStore;
        public ArrayManipulation(int [] dataSrote) 
        {
            DataStore = dataSrote;
        }

        public void DisplayArrayData()
        {
            foreach (var element in DataStore)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
        public void ChangeArrayElementValue(int elementIndex, int value)
        {
            DataStore[elementIndex] = value;
        }

    }
}
