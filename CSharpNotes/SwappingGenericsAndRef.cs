using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class SwappingGenericsAndRef
    {

        [Fact]
        public void CanSwapTheValuesOfTwoParameters()
        {
            int x = 10;
            int y = 20;

            // Step 2?
            Swap<int>(ref x, ref y);
            // Step 3 - Profit!
            Assert.Equal(20, x);
            Assert.Equal(10, y);

            string you = "Will";
            string me = "Jeff";

            // Step 2
            Swap<string>(ref you, ref me);

            Assert.Equal("Will", me);
            Assert.Equal("Jeff", you);

        }

        [Fact]
        public void TryingToParseSomething()
        {

        }

        public void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
