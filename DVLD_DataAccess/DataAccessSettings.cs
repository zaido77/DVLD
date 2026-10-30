using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    internal static class clsDataAccessSettings
    {
        public static string ConnectionString { get; set; } =
            "Server=.;Database=DVLD;User Id=sa;Password=123456;";
    }
}
