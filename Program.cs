using System;

namespace DotnetCore
{
    class Employee
    {
        public int Id { get; set;}
        public string Name {get; set;}
        public double Salary{get; set;}

        public override string ToString()
        {
            return $"{Id} - {Name} -{Salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated");
            Employee employee = new Employee{Id = 4001, Name = "Sazid", Salary = 3000000.000};
            
        }
    }
}
