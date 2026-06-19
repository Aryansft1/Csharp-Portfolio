using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public int Salary;
}

class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>();

        for (int i = 0; i < 3; i++)
        {
            Employee e = new Employee();

            Console.Write("Name: ");
            e.Name = Console.ReadLine();

            Console.Write("Salary: ");
            e.Salary = int.Parse(Console.ReadLine());

            list.Add(e);
        }

        Employee best = list[0];

        foreach (var e in list)
            if (e.Salary > best.Salary)
                best = e;

        Console.WriteLine("Top Employee: " + best.Name);
    }
}
