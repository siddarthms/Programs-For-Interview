using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Polymorphism
{
    public class cardTransaction : IInterface
    {
        public void Execute()
        {
            List<AmountDebittedCard> amountDebittedCards = new List<AmountDebittedCard>()
            {
                new AmountDebittedCard(10000),
                new DebitCard(20000)
            };
            foreach (var item in amountDebittedCards)
            {
                item.Card();
            }
         
        }
    }
}
