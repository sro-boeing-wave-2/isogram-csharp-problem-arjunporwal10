using System;
using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
    public class IsogramChecker
    {

        public static bool CheckIfIsogram(string inputString)
        {
            if (inputString == "")
                return true;
            string changedString = inputString.Replace("-", String.Empty).Replace(
                " ", String.Empty);
            List<char> datalist = new List<char>(changedString);
            if (datalist.Count != datalist.Distinct().Count())
            {
                return false;
            }

           else return true;
        }
    }
}
