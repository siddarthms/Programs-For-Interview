using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Polymorphism
{
    public class AmountDebittedCard
    {
        protected double Amount;

        public AmountDebittedCard(double Amount)
        {
            this.Amount = Amount;
        }
        public virtual void Card()
        {
            Console.WriteLine($"Amount has to be credited {Amount}");
        }
    }
}
