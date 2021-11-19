using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class BasicTypes
    {
        [Fact]
        public void CtsTypesAndAliases()
        {
            // DataType identifier [= initialize]
            int x;
            Int32 y = 32;

            String myName = "Jeff";
            string yourName = "Sam";

            string hisName;
            int hisAge;

            hisName = "Paul Atreides";
            hisAge = 28;
            Assert.Equal("Paul Atreides", hisName);
            Assert.Equal(28, hisAge);


           // Assert.Equal(5, hisName.Length);
        }

        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            var age = 52;
            var name = "Jeff";

            var rover = new Dog();

            Dog fido = new();

    

        }
    }

    public class Dog
    {

    }
}
