using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Bmi
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmi;
        private WeightCategory _weightCategory;

        public Bmi(float weightInPounds, float heightInInches, float bmi, WeightCategory weightCategory)
        {
            _weightInPounds = weightInPounds;
            _heightInInches = heightInInches;
            _bmi = bmi;
            _weightCategory = weightCategory;
        }
        public float weightInPounds { get { return _weightInPounds; } }
        public float heightInInches { get { return _heightInInches; } }
        public float bmi { get { return _bmi; } }
        public WeightCategory weightCategory { get { return _weightCategory; } }
    }
}
