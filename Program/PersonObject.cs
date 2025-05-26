using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class PersonObject : IInterface
    {
        public void Execute()
        {
            PersonModel person = new PersonModel
            {
                Name = "Alice",
                Id = 30,
                Description = "Term"
            };

        }
    }
}
