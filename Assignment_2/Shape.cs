using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// Abstract Class for shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets the color property
        /// </summary>
        /// <value>Color</value>
        protected string Color { get; set; }
        /// <summary>
        /// Calculatearaa abstract method which can be overridden by the the derived class
        /// </summary>
        /// <returns>returns area</returns>
        public abstract double CalculateArea();
        /// <summary>
        /// Declares a method to print the shape details
        /// </summary>
        public  void Print()
        {
            Console.WriteLine($"Color of the shape {nameof(Circle)} : {Color} with area {CalculateArea()}");
        }
    }
}
