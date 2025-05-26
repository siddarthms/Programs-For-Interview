using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class NoOfOcc : IInterface
    {
        public void Execute()
        {
            string word = "APPLE";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (charCount.ContainsKey(letter))
                {
                    charCount[letter]++;
                }
                else
                {
                    charCount[letter] = 1;
                }
            }

            foreach (var pair in charCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            //var res = word.GroupBy(x => x).Select(x => new
            //{
            //    x.Key,
            //    count = x.Count()
            //}).ToList();
                        
            //Console.WriteLine(JsonConvert.SerializeObject(res, Formatting.Indented));

        }
    }
}
