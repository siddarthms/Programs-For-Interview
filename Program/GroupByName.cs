using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Order {
        public int OrderID;
        public string? CustomerName;
        public decimal? Amount;
    }

    public class GroupByName : IInterface
    {
        public void Execute()
        {
            List<Order> orders = new List<Order>()
            {
                new Order { OrderID = 1, CustomerName = "Koushi", Amount = 10000 },
                new Order { OrderID = 2, CustomerName = "Mih",  Amount = 29999 },
                new Order { OrderID = 3, CustomerName = "Koushi",  Amount = 27999 },
            };

            orders.GroupBy(x => x.CustomerName).Select(s => new
            {
                Name = s.Key,
                Total = s.Sum(x=> x.Amount)
            });
            foreach (Order order in orders) {
                Console.WriteLine($"{order}");
            }
        }
    }
}
