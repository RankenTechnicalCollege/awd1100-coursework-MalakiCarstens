﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class ShinyCard : ICard 
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;
        private System.Drawing.Font _font;
        private System.Drawing.Color _backcolor;
        private System.Drawing.Color _forecolor;
        
        public ShinyCard(string name, System.Drawing.Image image, double value, System.Drawing.Font font, System.Drawing.Color backcolor, System.Drawing.Color forecolor)
        {
            _name = name;
            _image = image;
            _value = value;
            _font = font;
            _backcolor = backcolor;
            _forecolor = forecolor;
        }
        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            label.Text = _name;
            label.Font = _font; 
            label.BackColor = _backcolor; 
            label.ForeColor = _forecolor; 
        }

        public int CompareTo(ICard card)
        {

            if (Value > card.Value)
                return 1; 
            else if (Value < card.Value)
                return -1; 
            else
                return 0; 
        }
      
        public string Name
        {
            get { return _name; }
        }
        public System.Drawing.Image Image
        {
            get { return _image; }
        }
        public double Value
        {
            get { return _value; }
        }
    }
}