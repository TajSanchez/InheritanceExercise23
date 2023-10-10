using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
namespace Inheritance
{
   public class Reptile:Animal
    {
        public bool HasScales { get; set; }

        public bool IsVenomous { get; set; }

        public int Size { get; set; }

        public bool ColdBlooded { get; set; }
    }
}
