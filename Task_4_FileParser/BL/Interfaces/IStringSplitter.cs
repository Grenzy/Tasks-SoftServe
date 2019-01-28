﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_FileParser.BL.Interfaces
{
    public interface IStringSplitter
    {
        string[] SplitByIndexes(string source, int[] indexes, int patternLength);
    }
}
