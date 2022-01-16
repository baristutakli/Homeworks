using Week2.Extensions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week2.Extensions
{
    public static class StringMethodExtension
    {
       /// <summary>
       /// This function takes validator objects to check if the string is valid.
       /// </summary>
       /// <param name="param"></param>
       /// <param name="args"></param>
        public static bool MultipleValidator(this string param, params Validate[] args)
        {
            bool isValid = true;
            foreach (var item in args)
            {
                isValid = item.IsValid(param);
            }
            return isValid;
        }
    }
}
