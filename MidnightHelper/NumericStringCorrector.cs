using System;
using System.Collections.Generic;
using System.Text;

namespace MidnightHelper
{
    class NumericStringCorrector
    {
        string numericString;
        public string Corected { get => CorrectString(); }
        public NumericStringCorrector(string rawString)
        {
            numericString = rawString;
        }
        private string CorrectString()
        {
            if (numericString.Length < 2)
            {
                string newString = numericString.Insert(0, "0");
                return newString;
            }
            else return numericString;
        }
    }
}
