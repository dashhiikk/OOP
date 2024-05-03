using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    internal class AddTail: TimeDecorator
    {
        public string s;
        public AddTail(ITime time, string s) : base(time)
        {
            this.s = s;
        }
        public override string GetTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(time.GetTime());
            sb.Append(s);
            return sb.ToString();
        }
    }
}
