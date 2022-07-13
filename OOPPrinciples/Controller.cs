using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples;

public class Controller : Employee, IOvertime
{
    public Controller(string name, int age, double salary, string title) 
        : base(name, age, salary, title)
    {
    }

    public double CalculateOvertime(int extraHours)
    {
        return extraHours * 100000;
    }

    public override void DoWork()
    {
        Console.WriteLine("Cleared for Take off");
        base.DoWork();
    }
}
