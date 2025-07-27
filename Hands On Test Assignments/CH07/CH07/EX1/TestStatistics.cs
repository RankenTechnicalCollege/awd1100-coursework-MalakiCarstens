using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min = float.MaxValue;
        private float _max = float.MinValue;

        public TestStatistics()
        {

        }
        public void AddScore( float score )
        {
            if(score < 0 || score > 100)
            {
                throw new ArgumentException("The score must be 0-100.");
            }
            _count++;
            _sum += score;

            if (score < _min) { _min = score; }
            if (score > _max) { _max = score; }
           
        }
        public int Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Average { get { if (_count > 0) { return _sum / _count; } else { return 0; } } }
        public float Min { get { if (_count > 0) { return _min; } else { return 0; } } }
        public float Max { get { if (_count > 0) { return _max; } else { return 0; } } }
    }
}
