﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGen.Extensions.NumberInWords.Common
{
    public abstract class NumberInWordsService
    {
        public abstract string InWords(int value);
    }
}
