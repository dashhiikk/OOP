using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    internal class AddHead: TimeDecorator
    {
        public string s;
        public AddHead(ITime time, string s): base(time)
        {
            this.s = s;
        }
        public override string GetTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            sb.Append(time.GetTime());
            return sb.ToString();
        }
    }
}
