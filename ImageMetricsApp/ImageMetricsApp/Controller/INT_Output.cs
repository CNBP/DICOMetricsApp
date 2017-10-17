using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    interface INT_Output<TOne, TTwo>
    {
        void Send(TOne destination, TTwo InputList);
    }
}
