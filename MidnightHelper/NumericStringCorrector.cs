using System;
using System.Collections.Generic;
using System.Text;

namespace MidnightHelper
{
    class NumericStringCorrector
    {
        string numericString;
        const int minLenght = 2;
        const int beginOfString = 0;
        public string Corected { get => CorrectString(); }

        public NumericStringCorrector(string rawString)
        {
            numericString = rawString;
        }

        private string CorrectString()
        {
            if (numericString.Length < minLenght)
            {
                string newString = numericString.Insert(beginOfString, "0");
                return newString;
            }
            else return numericString;
        }
    }
}
