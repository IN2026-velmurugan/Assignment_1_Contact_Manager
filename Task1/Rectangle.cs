using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    /// <summary>
    /// Rectangle Class inheriting the shapes class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Gets Width of the Rectangle
        /// </summary>
        /// <value>Width Property</value>
        public double Width { get; init; } 
        /// <summary>
        /// Gets the height of the rectangle
        /// </summary>
        /// <value>Height property</value>
        public double Height { get; init; }
        /// <summary>
        /// Method to calculate the area of the rectangle overridden from shape
        /// </summary>
        /// <returns>Retuens area of the Rectanglereturns>
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
