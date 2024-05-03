using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    internal class AmericanTime : ITime
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture); ;
        }
    }
}
