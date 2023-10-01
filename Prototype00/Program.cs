using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persons p = new Persons();
            p.Age = 30; // set the person's age to 30
            p.Name = "Somila";
            int age = p.Age; // get the person's age (should be 30)
            p.PrintDetails();
        }
    }
}
