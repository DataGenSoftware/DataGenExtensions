﻿using DataGen.NumberToWords.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGen.NumberToWords.En
{
    public class NumberToWordsFactory : Common.NumberToWordsFactory
    {
        public override Common.NumeralsRepository CreateNumeralsRepository()
        {
            return new NumeralsRepository();
        }

        public override Common.NumberToWordsService CreateNumberToWordsService(Common.NumeralsRepository numeralsRepository)
        {
            return new NumberToWordsService(numeralsRepository);
        }
    }
}
