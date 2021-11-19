using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public  class PatternsForModifyingObjects
    {

        [Fact]
        public void PassingTheEmployee()
        {
            var bob = new Employee();
            bob.Name = "Robert";
            bob.Salary = 120000;

            var updatedBob = EvaluateEmployee(bob);

            Assert.Equal(120000, bob.Salary);

            Assert.Equal("Robert", updatedBob.Name);
            Assert.Equal(132000, updatedBob.Salary);
        }


        [Fact]
        public void ImmutableRecords()
        {
            var bob = new Employee2("Robert", 120000);
            Assert.Equal("Robert", bob.Name);

           
        }

        public Employee2 EvaluateEmployee2(Employee2 emp)
        {
            return emp with { Salary = emp.Salary * 1.1M };

           
        }

        public Employee EvaluateEmployee(Employee emp)
        {
            // look up the records..
            

            var result = new Employee();
            result.Name = emp.Name;
            result.Salary = emp.Salary * 1.1M;
            return result;
        }

    }

    public class Employee
    {
        public string Name;
        public decimal Salary;

    }

    public record Employee2(string Name, decimal Salary);

}
