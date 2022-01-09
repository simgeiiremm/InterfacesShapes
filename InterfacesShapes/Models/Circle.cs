using InterfacesShapes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models
{
    internal class Circle : IRoundedShape
    {
        public double radius { get; set; }
        public bool IsPiThree { get; set; } = true;

        //double pi = 3.14;

        public double CalculateArea()
        {
            //double pi = Math.PI;
            //if (IsPiThree)
            //    pi = 3;
            double pi = IsPiThree ? 3 : Math.PI; //ternary operator
            return pi * radius * radius;
        }

        public double CalculateCircumference()
        {
            //double pi = Math.PI;
            //if (IsPiThree)
            //    pi = 3;
            double pi = IsPiThree ? 3 : Math.PI;
            return 2 * pi * radius;
        }
    }
}
