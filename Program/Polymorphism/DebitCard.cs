using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Polymorphism
{
    public class DebitCard : AmountDebittedCard
    {
        public DebitCard(double Amount) : base(Amount)
        {
        }

        public override void Card()
        {
            Console.WriteLine($"Debit ur amount{Amount}");
        }
    }
}
