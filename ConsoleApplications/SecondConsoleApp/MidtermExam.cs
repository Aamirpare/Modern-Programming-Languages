using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WindowsFormsShoppingApp
{
    public class MidtermExam
    {
        //Question 1
        public void MidtermQuestion1()
        {
            //a. Declare Two dimension array and initialize it.
            int[,] twoDArray1 = new int[2,3]{ { 1, 4, 2 }, { 3, 6, 8 } };
            int[,] towDArray2 = { { 1, 4, 2 }, { 3, 6, 8 } }; 
            var twoDArray3 = new int[2, 3] { { 1, 4, 2 }, { 3, 6, 8 } };

            //b. Declare and initialize a single dimension array
            int [] oneDArray1 = new int[] { 51, 22, 33, 34, 55, 16, 70 };
            int[] oneDArray2 = { 51, 22, 33, 34, 55, 16, 70};
            var oneDArray3 = new int[] { 51, 22, 33, 34, 55, 16, 70 };

            //C. Access the elements of the single dimension array
            int index = 0;
            foreach (var element in oneDArray1)
            {
                if(element % 2 != 0)
                {
                    oneDArray1[index++] = element + 1;
                    continue;
                }
                index++;
            }
            Console.WriteLine();
        }
    }

    //Question 2 part a.
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Question 2 part b.

        public void Question2PartB()
        {
            var products = new List<Product> 
            {  
                new Product{ Id=1, Name="Infinix Note 30", Price = 46000 },
                new Product{ Id=2, Name="Samsung Note 20", Price = 96000 },
                new Product{ Id=3, Name="Redmi Note 13 Pro", Price = 76000 },
            };
        }
    }

    //Question # 3
    public class Arithmetic
    {
        public delegate void OperationHandler(string m);
        public event OperationHandler OperationCompleted;
        public int Add(int a, int b)
        {
            var result = a + b;
            OperationCompleted?.Invoke("Add operation completed.");
            return result;
        }
        public int Subtrat(int a, int b)
        {
            var result =  a - b;
            OperationCompleted?.Invoke("Subtract operation completed");
            return result;
        }
        public int Multiply(int a, int b)
        {
            var result = a * b;
            OperationCompleted?.Invoke($"Multiply operation completed - result: {a}x{b} = {result}");
            return result;
        }
        public int Devide(int a, int b)
        {
            var result = a / b;
            OperationCompleted?.Invoke("Divide operation completed");
            return result;
        }
    }
    public class ArithmeticDemo
    {
        public void Execute()
        {
            var am = new Arithmetic();
            //Register the event
            am.OperationCompleted += OperationCompleted;
            am.Add(30, 90);
            am.Subtrat(30, 90);
            am.Multiply(30, 90);
            am.Devide(30, 90);
        }

        private  void OperationCompleted(string m)
        {
            Console.WriteLine(m);
        }
    }
}
