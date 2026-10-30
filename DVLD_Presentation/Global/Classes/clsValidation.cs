using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Presentation.Global_Classes
{
    internal class clsValidation
    {
        public static bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool ValidateInteger(string Number)
        {
            return Regex.IsMatch(Number, @"^[0-9]*$");
        }

        public static bool ValidateFloat(string Number)
        {
            return Regex.IsMatch(Number, @"^[0-9]*(?:\.[0-9]*)?$");
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }

    }
}
