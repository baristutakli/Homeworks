﻿using Week2.Extensions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Extensions.Validators
{
    public class LowerCaseValidator : Validate
    {
        public override bool IsValid(string str)
        {
            var result = str.Any(c => Char.IsLower(c));
            return result;
        }
    }
}
