using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Presentation.Global.Classes
{
    public static class clsFormat
    {
        public static string DateToString(DateTime Date)
        {
            return Date.ToString("dd/MMM/yyyy");
        }
    }
}
