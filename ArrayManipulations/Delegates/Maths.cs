using System;

namespace ArrayManipulations.Delegates
{
    internal class Maths
    {
        delegate int Arithmetics(int a, int b);
        int Add(int a, int b)
        {
            return a + b;
        }
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
}
