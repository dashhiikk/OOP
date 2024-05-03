using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    internal class EuropeanTime: ITime
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); ;
        }
    }
}
