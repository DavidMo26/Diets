using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    internal class Sportman
    {
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool isVeg { get; set; }

        public Sportman(int age, double height, double weight, bool isVeg)
        {
            Age = age;
            Height = height;
            Weight = weight;
            this.isVeg = isVeg;
        }
    }
}
