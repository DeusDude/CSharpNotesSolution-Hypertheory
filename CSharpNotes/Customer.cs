using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNotes
{
    public class Customer 
    {
        public Customer(): this("", "", 5000)
        {
            CreditLimit = 5000;
        }
        public Customer(string firstName, string lastName, decimal creditLimit)
        {
            FirstName = firstName;
            LastName = lastName;
            CreditLimit = creditLimit;
        }
        // "Auto Property"
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { 
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
        public decimal CreditLimit { get; private set; } 

        public void MakePurchase(decimal amount)
        {
            CreditLimit -= amount;
        }

        public void MakePurchase(decimal amount, int qty)
        {
            MakePurchase(amount * qty);
        }
        public override string ToString()
        {
            return $"Customer is {FullName} is awesome";
        }

        public void SendBirthdayCard(string note = "Happy Birthday")
        {

        }

    }
}
