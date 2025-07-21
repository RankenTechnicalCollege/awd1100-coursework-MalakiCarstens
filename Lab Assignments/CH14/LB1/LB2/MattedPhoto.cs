using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class MattedPhoto : Photo
    {
        protected Color _color;

        public MattedPhoto(float width, float height, Color color) : base(width, height )
        {
            _color = color;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_color}";
        }
        public Color Color { get { return _color; } set { _color = value; } }
        public override float Price { get { return base.Price + 10f; } }
    }
}
