using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    interface INT_Display<T>
    {
        void SetDisplay(T Content);
        T GetDisplay();
    }
}
