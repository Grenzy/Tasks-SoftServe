﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Envelopes.BL.Interfaces
{
    internal interface INestable<T>
    {
        int IsNested(T other);
    }
}
