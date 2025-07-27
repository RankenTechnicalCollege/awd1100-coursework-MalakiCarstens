using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class InvalidHeightException : ArgumentException
    {
        public InvalidHeightException(String message) : base(message)
        {

        }
    }
}
