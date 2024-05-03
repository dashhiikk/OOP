using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab1n2
{
    abstract class TimeDecorator: ITime
    {
        protected ITime time;
        public TimeDecorator(ITime time)
        {
            this.time = time;
        }
        public abstract string GetTime();
    }
}
