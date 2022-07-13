using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples;

public class Employee
{
    public Employee(string name, int age, double salary, string title)
    {
        Name = name;
        Age = age;
        Salary = salary;
        JobTitle = title;
    }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string JobTitle { get; set; }
    public int Age { get; private set; }

    public void SetAge(int value)
    {
        if(Age > 0 && Age < 70)
            Age = value;
    }


    public void TakeLeave()
    {
        Console.WriteLine("Im away for the next 30 days");
    }

    public void DoAppraisal()
    {
        Console.WriteLine("Fill in form");
        Console.WriteLine("Sit with supervisor");
        Console.WriteLine("Sign the form");
    }

    public virtual void DoWork()
    {
        Console.WriteLine("Read and respond to emails");
        Console.WriteLine("Walk around the building");
    }
}

