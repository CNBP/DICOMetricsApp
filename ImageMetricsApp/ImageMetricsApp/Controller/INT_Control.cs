﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    interface INT_Control<T>
    {
        T GetControl(string ControlName);
    }
}
