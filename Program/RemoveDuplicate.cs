using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class RemoveDuplicate : IInterface
    {
        public void Execute()
        {
            int[] data = new int[] { 1, 2, 2, 3, 4, 4 };
            //var distinctList = data.Distinct().ToList();
            //Console.WriteLine(string.Join(", ", distinctList));
            List<int> list = new List<int>();
            //o/p -> 1,3 for unique data removes if exist already
            for (int i = 0; i < data.Length; i++)
            {
                if(list.Contains(data[i]))
                {
                    list.RemoveAll(j=> data[i] == j); // removes the first value that occurs in the list
                }
                else
                {
                    list.Add(data[i]);
                }
            }
            //o/p -> 1,2,3, 4 for distinct output add what list doesnt contains
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (!list.Contains(data[i]))
            //    {
            //        list.Add(data[i]);
            //    }
            //}
            Console.WriteLine(String.Join(',', list));
        }
    }
}