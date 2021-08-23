using System;

namespace DotnetCore
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated");
            Employee employee = new Employee{Id = 4001, Name = "Sazid", Salary = 3000000.000};
            Console.WriteLine(employee);
        }
    }
}
