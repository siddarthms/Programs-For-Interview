using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class ReverseTheSentance : IInterface
    {
        public void Execute()
        {
            string input = " hello my name is kochika ";
            input = input.Trim();
            var arr = input.Split(" ");
            StringBuilder builder = new StringBuilder("");

            for(int i = arr.Length - 1; i >= 0; i--)
            {
                builder.Append(arr[i]).Append(" ");
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
