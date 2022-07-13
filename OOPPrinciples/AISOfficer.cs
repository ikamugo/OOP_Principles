using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class AISOfficer : Employee, IOvertime
    {
        public AISOfficer(string name, int age, double salary, string title) 
            : base(name, age, salary, title)
        {
        }

        public double CalculateOvertime(int extraHours)
        {
            return extraHours * 20000;
        }
    }
}
