using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    class CTL_Output_CSV : INT_Output<string, List<int>>
    {
        public void Send(string destination, List<int> Data)
        {
            throw new NotImplementedException();
        }
    }
}
