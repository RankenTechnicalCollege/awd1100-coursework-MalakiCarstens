using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public class DecoderRing
    {
        private int _shift;
        private string _innerRing;
        private string _outerRing;

        public DecoderRing(int shift, string innerRing, string outerRing)
        {
            _shift = shift;
            _innerRing = innerRing;
            _outerRing = outerRing;
        }
        public DecoderRing()
        {
            _outerRing = "abcdefghijklmnopqrstuvwxyz";
            Shift = 0;
        }
        public string Decode(string text)
        {
            text = text.Trim().ToLower();
            string result = "";
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    throw new InvalidCharacterException("Entry must be a letter.");
                }
                int index = _outerRing.IndexOf(c);
                if (index >= 0)
                {
                    result = result + _innerRing[index];
                }
            }
            return result;
        }
        public string Encode(string text)
        {
            text = text.Trim().ToLower();
            string result = "";
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    throw new InvalidCharacterException("Entry must be a letter.");
                }
                int index = _innerRing.IndexOf(c);
                if (index >= 0)
                {
                    result = result + _outerRing[index];
                }
            }
            return result;
        }
        public int Shift { get { return _shift; } set { if (value < 0 || value > 25) { MessageBox.Show("Shift must be between 0 and 25."); return; } _shift = value; _innerRing = _outerRing.Substring(_shift) + _outerRing.Substring(0, _shift); } }
    }
}
