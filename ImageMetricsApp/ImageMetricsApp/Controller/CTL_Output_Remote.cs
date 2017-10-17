using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    class CTL_Output_Remote : INT_Output<string, List<int>>
    {
        public void Send(string destination, List<int> Input)
        {
            throw new NotImplementedException();
        }
        /*
         *             if (Label > 40)
            {
                UserCase.WriteCSVLabel(Label);
            }
            else if (Label > 30)
            {
                UserCase.WriteExcelLabel(Label);
            }
            else if (Label > 20)
            {
                UserCase.WriteWWWLabel(Label);
            }
         */
    }
}
