using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class ReverseTheGivenNumber : IInterface
    {
        public void Execute()
        {
            int input = 12345;
            int intialnumber = 0;
            while (input > 0)
            {

                int lastnumber = input % 10;
                intialnumber = intialnumber * 10 + lastnumber;
                input = input/ 10;
            }

            Console.WriteLine(intialnumber);
        }
    }
}
