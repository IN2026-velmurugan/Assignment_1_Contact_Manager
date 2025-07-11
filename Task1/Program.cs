namespace Assignments
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Arguments from main</param>
        public static void Main(string[] args)
        {
            Shape rectangle = new Rectangle
            {
                Width = 100,
                Height = 5
            };
            rectangle.Color = "blue";
            Shape circle = new Circle { Radius = 5 };
            circle.Color = "red";
            rectangle.Print();
            circle.Print();
            Console.ReadKey();
        }
    }
}