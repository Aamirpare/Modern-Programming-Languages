using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations.Questions
{
    public class Delegates
    {
        public delegate void OperationHandler(string what);
        public delegate int Arithmetics(int a, int b);
        public event OperationHandler OnAddBegin;
        int Add(int a, int b)
        {
            OnAddBegin?.Invoke("Operation Started...");
            return a + b;
        }
        //In case of the above code is missing.
        //Write the missing code so that the following program will execute without any error?
        public void CreateDelegates()
        {
            Arithmetics addOperation = new Arithmetics(Add);
            Arithmetics subOperation = new Arithmetics((a, b) => a - b);
            Arithmetics mulOperation = new Arithmetics((a, b) => a * b);
            Arithmetics divOperation = new Arithmetics(delegate (int a, int b) { return a / b; });

            Console.WriteLine($"Add = {addOperation(50, 10)}");
            Console.WriteLine($"Sub = {subOperation(50, 10)}");
            Console.WriteLine($"Mul = {mulOperation(50, 10)}");
            Console.WriteLine($"Div = {divOperation(50, 10)}");

            //What will be the output of the following code?
            mulOperation = subOperation;
            Console.WriteLine($"Mul = {mulOperation(50, 10)}");
        }
    }

    public class UsingEvents
    {
        public void ExecuteEvents()
        {
            var del = new Delegates();
            del.OnAddBegin += OnAddBegin;
        }

        private void OnAddBegin(string what)
        {
            Console.WriteLine(what);
        }

    }
}
