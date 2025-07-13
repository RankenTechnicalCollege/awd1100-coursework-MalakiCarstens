using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Conferences
{
    public class Conferences
    {
        public string Display()
        {
            return $"({Attendees}) attendees\n {GroupName}\n on {StartingDate.ToShortDateString()}\n in {Room}.";
        }
        public string GroupName { get; set; }
        public DateTime StartingDate { get; set; }
        public int Attendees { get; set; }
        public Room Room { get; set; }
    }
}
