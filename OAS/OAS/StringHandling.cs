using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAS
{
    public class StringHandling
    {
        public Decimal ExtractDecimalFromString(string str)
        {
            var sb = new StringBuilder();
            foreach (var c in str.Where(c => c == '.' || Char.IsDigit(c)))
            {
                sb.Append(c);
            }
            return Convert.ToDecimal(sb.ToString());
        }
    }
}
