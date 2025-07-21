﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class NormalCard : ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;

        public NormalCard(string name, System.Drawing.Image image, double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }
        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            label.Text = _name;
            label.BackColor = System.Drawing.Color.Black;
            label.ForeColor = System.Drawing.Color.White;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Regular);
        }
        public string Name { get { return _name; } }
        public System.Drawing.Image Image { get { return _image; } }
        public double Value { get { return _value; } }

    public int CompareTo(ICard card)
        {

            if (Value > card.Value)
                return 1;
            else if (Value < card.Value)
                return -1;
            else
                return 0;
        }
      }
    }
