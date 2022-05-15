using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    abstract class DietBase
    {
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        protected DietBase(int age, double height, double weight)
        {
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
