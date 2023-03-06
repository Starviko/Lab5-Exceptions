using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Exceptions
{
    internal class Circle
    {
        public double Radius { get; set; }
        public void SetRadius(double radius)
        {
            if (radius <= 0) 
            {
                throw new InvalidRadiusException(radius);
            }
            else
                this.Radius=radius;
        }

        public override string ToString()
        {
            return $"A circle with a radius {Radius}.";
        }
        //public Circle(double radius)
        //{
        //    Radius = radius;
        //}
    }
}
