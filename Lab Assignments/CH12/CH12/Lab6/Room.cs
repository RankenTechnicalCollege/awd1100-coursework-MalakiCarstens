using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = width * length;
            _boxes = (_area + 11) / 12 + 1;
        }

        public string name { get { return _name; } }
        public int width { get { return _width; } }
        public int length { get { return _length; } }
        public int area { get { return _area; } }
        public int boxes { get { return _boxes; } }
    }
}
