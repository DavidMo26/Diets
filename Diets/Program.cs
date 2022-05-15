using System;

namespace MethodFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportman s1 = new Sportman(25, 1.80, 86, true);
            Sportman s2 = new Sportman(25,1.02, 120, false);
            Sportman s3 = new Sportman(25, 1.60, 77, false);
            Sportman s4 = new Sportman(25, 1.90, 90, false);

            Nutritionist nutritionist = new Nutritionist();
            nutritionist.GetDietForSportman(s1);
            nutritionist.GetDietForSportman(s2);
            nutritionist.GetDietForSportman(s3);
            nutritionist.GetDietForSportman(s4);
        }
    }
}