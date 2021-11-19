using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class ValuesAndReferences
    {

        [Fact]
        public void PassingValueTypes()
        {
            int x = 10;
            int y = 20;

            var answer = Add(x, y);

            Assert.Equal(60, answer);
            Assert.Equal(10, x);
            Assert.Equal(20, y);
        }
        [Fact]
        public void PassingReferenceTypes()
        {
            var c = new Cat();
            c.Name = "Joe";

            MessWithACat(c);

            Assert.Equal("Fluffy!", c.Name);
        }


        [Fact]
        public void StringsAreImmutable()
        {
            // Immutable means you can't change (mutate the thing)
            var name = "Jeff";

            name += " Gonzalez";

            Assert.Equal("Jeff Gonzalez", name);
        }

        [Fact]
        public void BuildingABigString()
        {
            //var numbers = "";
            var numbers = new StringBuilder();
            foreach(var num in Enumerable.Range(1,1000))
            {
               numbers.Append(num.ToString() + ", ");
            }

            Assert.True(numbers.ToString().StartsWith("1, 2, 3, 4, 5, 6"));
        }
        [Fact]
        public void StringsActLikeValuesForAssignment()
        {
            var x = "Joe";
            MessWithAString(x);
            Assert.Equal("Joe", x);
        }
        private void MessWithAString(string c)
        {
            c = "Fluffy!";
        }
        private void MessWithACat(Cat c)
        {   // "Side Effect"
            c.Name = "Fluffy!";
        }

        private int Add(int a, int b)
        {
            a = a * 2;
            b = b * 2;
            return a + b;
        }
    }

    public class Cat
    {
        public string Name;
    }
}
