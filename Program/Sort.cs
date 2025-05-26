using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Sort : IInterface
    {
        public void Execute()
        {
            // with predefined
            //int[] arr = new int[] { 2, 1, 4, 6, 8, 3 };
            //Array.Sort(arr);
            //StringBuilder result = new StringBuilder();
            //foreach (int i in arr)
            //{
            //    result = result.Append( i + ",");
            //}
            //Console.Write(result.ToString().TrimEnd(','));
            //Console.Write(string.Join(",", arr));
           

            //linq
            //int[] arr = new int[] { 2, 1, 4, 6, 8, 3 };
            //var res = arr.OrderBy(x => x).ToArray();
            //Console.WriteLine(String.Join(',', res));

            //with linq and without trim function
            //int[] arr = new int[] { 2, 1, 4, 6, 8, 3 };
            //var value = arr.OrderBy(x => x).ToArray();
            //string res = String.Empty;
            //int count = 0;
            //foreach (var x in value)
            //{
            //    res += x;      
            //    if(count < value.Length - 1)
            //    {
            //        res = res + ",";
            //    }
            //    count++;
            //}
            //Console.WriteLine(res);

            //Sorting without predefined func 
            int[] arr = new int[] { 2, 1, 9, 6, 8, 3 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)          
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(",", arr));
        }
    }
}
