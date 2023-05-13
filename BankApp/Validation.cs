using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class Validation
    {
            public static bool TryParseInt(string input, out int result)
            {
                return int.TryParse(input, out result);
            }
    }
}
