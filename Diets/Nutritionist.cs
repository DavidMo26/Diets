using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    internal class Nutritionist
    {
        private DietFactory DietFactory;

        public void GetDietForSportman(Sportman sportman)
        {
            double BMI = sportman.Weight / (sportman.Height* sportman.Height);
            if (sportman.isVeg == true)
                GetVegDiet(sportman);
            if(BMI>25 && BMI < 27)
                GetAtkinsDiet(sportman);
            else 
                GetPaleoDiet(sportman);
        }

        private void GetVegDiet(Sportman sportman)
        {
            DietFactory = new VegDietFactory(sportman.Age, sportman.Height, sportman.Weight);
            DietFactory.GetDiet();
        }

        private void GetPaleoDiet(Sportman sportman)
        {
            DietFactory = new PaleoDietFactory(sportman.Age, sportman.Height, sportman.Weight);
            DietFactory.GetDiet();
        }

        private void GetAtkinsDiet(Sportman sportman)
        {
            DietFactory = new AtkinsDietFactory(sportman.Age, sportman.Height, sportman.Weight);
            DietFactory.GetDiet();
        }
    }
}
