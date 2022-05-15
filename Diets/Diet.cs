using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class VegDiet : DietBase
    {
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public VegDiet(int age, double height, double weight) : base(age, height, weight) { }
    }

    class PaleoDiet : DietBase
    {
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public PaleoDiet(int age, double height, double weight) : base(age, height, weight) { }
    }

    class AtkinsDiet : DietBase
    {
        private string name { get; set; }
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public AtkinsDiet(int age, double height, double weight) : base(age, height, weight) { }       
    }
}
