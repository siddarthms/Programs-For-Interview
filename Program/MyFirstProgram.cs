using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class MyFirstProgram : IInterface
    {
        public void Execute()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
               
            Console.WriteLine( list.FirstOrDefault());

        }
    }
}
