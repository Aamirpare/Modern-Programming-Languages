using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulations.Generics
{

    public class Address
    {
        public string Street { get; set; }
        public string State { get; set; }
    }
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Address Address { get; set; }
    }
}
