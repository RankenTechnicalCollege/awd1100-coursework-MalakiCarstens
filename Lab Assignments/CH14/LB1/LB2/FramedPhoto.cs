using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class FramedPhoto : Photo
    {
        protected Material _material;
        protected Style _style;
        public FramedPhoto(float width, float height, Material material, Style style) : base(width, height)
        {
            _material = material;
            _style = style;
        }
        public override string ToString()
        {
            return base.ToString() + $"({_material}, {_style})";
        }
        public Material Material { get { return _material; } set { _material = value; } }
        public Style Style { get { return _style; } set { _style = value; } }
        public override float Price
        {
            get { return base.Price + 25f; }
        }
    }
}
