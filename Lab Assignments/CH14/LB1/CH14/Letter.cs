using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14
{
    public class Letter
    {
        protected string _recipient;
        protected DateTime _sentDate;

        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }
        public override string ToString()
        {
            return $"{_sentDate.ToShortDateString()}, {_recipient}, {Price:C}";
            
        }
        public string Recipient { get { return _recipient; } }
        public DateTime SentDate { get { return _sentDate; } }
        public virtual double Price { get { return 0.50; } }
    }
}
