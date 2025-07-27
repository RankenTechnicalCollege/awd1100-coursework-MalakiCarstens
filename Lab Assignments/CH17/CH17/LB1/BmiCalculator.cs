using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public static class BmiCalculator
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
             float bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
            WeightCategory weight = new WeightCategory();
            if (bmi < 18.5f)
            {
                weight = WeightCategory.UNDERWEIGHT;
            }
            else if (bmi < 25f)
            {
                weight = WeightCategory.NORMAL;
            }
            else if (bmi < 30f)
            {
                weight = WeightCategory.OVERWEIGHT;
            }
            else
            {
                weight = WeightCategory.OBESE;
            }
            Bmi result = new Bmi(weightInPounds,heightInInches,bmi,weight);
            return result;
        }
    }
}
