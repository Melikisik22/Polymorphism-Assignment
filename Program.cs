using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Id = 200,
                FirstName = "Ali",
                LastName = "Khan"
            };

            IQuittable quittableEmployee = emp;

            quittableEmployee.Quit();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
