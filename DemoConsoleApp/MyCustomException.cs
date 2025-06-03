using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class TooYoungException : Exception
    {
        public TooYoungException(string message) : base(message)
        {
        }

        public TooYoungException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
