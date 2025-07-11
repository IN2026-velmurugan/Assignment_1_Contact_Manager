using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// Sircle shape inheriting shape
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Gets
        /// </summary>
        /// <value>
        /// Radius of the circle
        /// </value>
        public double Radius { get; init; }
        /// <summary>
        /// Method to calculate the area of the circle overridden from shape
        /// </summary>
        /// <returns>Retuens area of the circle</returns>
        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }
}
