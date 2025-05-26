using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Encapsulation : IInterface
    {
        public void Execute()
        {
            Name n = new Name();
            n.SetName("Koushika");
           Console.WriteLine(n.GetName());
        }
    }

    public class Name
    {
        private string custName;

        public void SetName(string PersonName)
        {
            custName = PersonName;
        }

        public string GetName()
        {
            return custName;
        }
    }
}
