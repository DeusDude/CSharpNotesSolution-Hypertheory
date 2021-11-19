using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class ObjectsAndProperties
    {
        [Fact]
        public void UsingProperties()
        {
            var customer = new Customer();
            customer.FirstName = "Bob";
            customer.LastName = "Smith";
            Assert.Equal("Smith, Bob", customer.FullName);

          //  Assert.Equal("Customer is Bob Smith is awesome", customer.ToString());
            Assert.Equal(5000M, customer.CreditLimit);
            customer.MakePurchase(2000M);
            Assert.Equal(3000M, customer.CreditLimit);

  
         }

        [Fact]
        public void InitializingObjects()
        {
           
            var c = new Customer()
            {
                FirstName = "Laurie",
                LastName = "Anderson"
            };
           

          
            Assert.Equal("Anderson, Laurie", c.FullName);
            c.MakePurchase(1.99M, 3);
            c.SendBirthdayCard();
            c.SendBirthdayCard("Let's Get Tacos and talk about Lou!");

            var x = new Customer();
            Assert.Equal("", x.FirstName);
            Assert.Equal(5000, x.CreditLimit);
        }
    }
}
