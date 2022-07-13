using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples;

public class Engineer: Employee
{
    public Engineer(string name, string title, int age, double salary)
        :base(name, age, salary, title)
    {
        
    }

    public override void DoWork()
    {
        Console.WriteLine("Calibrate ILS");
        Console.WriteLine("Perform corrective maintenance");
    }
}
