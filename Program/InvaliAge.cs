using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age is Invalid") { }
    }
    public class InvaliAge : IInterface
    {
        public void Execute()
        {
           Age age = new Age();
            age.Calculate(17);
        }
    }

    public class Age
    {
        public void Calculate(int Age)
        {
            try
            {
                if (Age > 0 & Age <= 18)
                {
                    Console.WriteLine("Expected age" + " " + "Thanks!");
                }
                else
                {
                    throw new InvalidAgeException();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
