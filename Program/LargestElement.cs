using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LargestElement : IInterface
    {
        public void Execute()
        {
            int[] arr = new int[] { 5, 3, 7, 12 };
            int value = arr[0];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if(arr[i] > value)
                {
                    value = arr[i];
                }
            }
            Console.WriteLine(value);
        }
    }
}
