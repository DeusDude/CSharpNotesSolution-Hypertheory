using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNotes.Hr;

public class Employee
{


    public Employee(string department, decimal salary)
    {
        Department = department;
        Salary = salary;
    }

    public string Department { get; private set; }
    public decimal Salary { get; private set; }
}


public class Contractor : Employee
{
    public Contractor(decimal salary): base("Contractor", salary)
    {
        
    }
}
