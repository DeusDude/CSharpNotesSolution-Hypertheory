using System;
using Xunit;

namespace CSharpNotes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given (Arrange)
            int a = 10, b = 20, answer;
            // When (Act)
            answer = a + b;
            // Then (Assert)
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,2, 12)]

        public void CanAdd(int a, int b, int expected)
        {
            int answer = a + b;
            // Then (Assert)
            Assert.Equal( expected, answer);
            
        }
    }
}
