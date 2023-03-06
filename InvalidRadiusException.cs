using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Exceptions
{
    internal class InvalidRadiusException:Exception
    {
        public double Radius { get; set; }
        public InvalidRadiusException() : base("Invalid radius.")
        { 
        }
        public InvalidRadiusException(double radius) :base($"Invalid radius value: {radius}") 
        { 
            this.Radius = radius;
        }
    }
}
