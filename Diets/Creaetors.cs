using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    class VegDietFactory : DietFactory
    {
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public VegDietFactory(int age,double height, double weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override DietBase GetDiet()
        {
            Console.WriteLine("eggs,cheese,vegetables,fruits");
            return new VegDiet(age, height, weight);
        }

    }

    class PaleoDietFactory : DietFactory
    {
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public PaleoDietFactory(int age, double height, double weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override DietBase GetDiet()
        {
            Console.WriteLine("eggs,cheese,vegetables,fruits,chiken,meat");
            return new PaleoDiet(age, height, weight);
        }
    }

    class AtkinsDietFactory : DietFactory
    {
        private int age { get; set; }
        private double height { get; set; }
        private double weight { get; set; }

        public AtkinsDietFactory(int age, double height, double weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public override DietBase GetDiet()
        {
            Console.WriteLine("eggs,cheese,vegetables,fruits,chiken,meat,nuts");
            return new AtkinsDiet(age, height, weight);
        }
    }
}
    
