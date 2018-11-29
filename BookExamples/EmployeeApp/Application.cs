using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeApp
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation*****\n");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);

            // Use the get/set methods to interact with the object's name.
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());

            //emp.Age = 26;
            emp.Age++;
            emp.DisplayStats();


            Console.ReadLine();


        }
    }
}
