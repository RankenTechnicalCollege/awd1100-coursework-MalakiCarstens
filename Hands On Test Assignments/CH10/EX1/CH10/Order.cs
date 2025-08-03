using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    public class Order
    {
        public Occasion selectedOccasion {  get; set; }
        public Style selectedStyle { get; set; }
        public bool AddEnvelope { get; set; }
        public bool AddStamp { get; set; }
        public bool AddMessage { get; set; }

        public string CustomMessage { get; set; }

        public decimal CalculateTotal()
        {
            decimal total = selectedStyle.Price;

            if (AddEnvelope)
            {
                total += 0.25m;
            }
            if (AddStamp)
            {
                total += 0.50m;
            }
            if (AddMessage)
            {
                total += 0.25m;
            }
            return total;
        }
    }
}
