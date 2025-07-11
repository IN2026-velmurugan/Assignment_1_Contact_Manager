namespace Assignments
{
    /// <summary>
    /// Employee base class
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Gets Name
        /// </summary>
        /// <value>Name</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets Salary
        /// </summary>
        /// <value>Salary</value>
        public decimal Salary {  get; set; }
        /// <summary>
        /// Adbstract method to calculate bonus
        /// </summary>
        /// <returns>returns the bonus of the employee</returns>
        public abstract double CalculateBonus();
        /// <summary>
        /// Method to print employee detail
        /// </summary>
        public void PrintDetails()
        {

        }
    }
}