using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_and_parameters_salary_employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter working hours:");
            int workingHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of working days:");
            int numWorkingDays = int.Parse(Console.ReadLine());

            int projectHandles = 0;
            int extras = 0;

            if (employeeType == 2 || employeeType == 3)
            {
                Console.WriteLine("Enter project handles:");
                projectHandles = int.Parse(Console.ReadLine());
            }

            if (employeeType == 3)
            {
                Console.WriteLine("Enter extra hours:");
                extras = int.Parse(Console.ReadLine());
            }

            int monthlySalary = CalculateMonthlySalary(employeeType, workingHours, numWorkingDays, projectHandles, extras);

            Console.WriteLine($"Monthly Salary: {monthlySalary}");
        }

        static int CalculateMonthlySalary(int employeeType, int workingHours, int numWorkingDays, int projectHandles = 0, int extras = 0)
        {
            int baseSalary = workingHours * numWorkingDays * 100;

            if (employeeType == 1 || employeeType == 2)
            {
                return baseSalary + projectHandles * 3000;
            }
            else if (employeeType == 3)
            {
                return baseSalary + projectHandles * 3000 + extras * 2000;
            }
            else
            {
                throw new ArgumentException("Invalid employee type");
            }
        }
    }
}
    
