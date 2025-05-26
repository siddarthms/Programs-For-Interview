using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Math : IInterface
    {
        //static class cannot be instantiated
        // cannot be inherited
        public void Execute()
        { 
           var A = MathImplementation.square(2);
           var B = MathImplementation.cube(3);
           Console.WriteLine(A + B);
        }
    }
}
