using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class EmployeeTests
    {

        [Fact]
        public void WorkingWithAnEmployee()
        {
            var joe= new Hr.Employee("DEV", 250000);

            Assert.Equal("DEV", joe.Department);


            var jeff = new Hr.Contractor(80000);
            Assert.Equal("Contractor", jeff.Department);
            Assert.Equal(80000, jeff.Salary);

        }
    }
}
