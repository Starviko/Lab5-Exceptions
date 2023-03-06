using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.SetRadius(100);
            Console.WriteLine(c1);
            Console.WriteLine();
            try
            {
                Circle c2 = new Circle();
                c2.SetRadius(-100);
                Console.WriteLine(c2);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("The radius " + ex.Radius + " is invalid.");
                Console.WriteLine("Please set a valid radius.");
                Console.WriteLine();
            }

            try
            {
                Circle c3 = new Circle();
                c3.SetRadius(0);
                Console.WriteLine(c3);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("The radius " + ex.Radius + " is invalid.");
                Console.WriteLine("Please set a valid radius.");
                Console.ReadKey();
            }
        }
    }
}
