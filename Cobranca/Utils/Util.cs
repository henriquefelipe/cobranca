using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cobranca.Utils
{
    public class Util
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string GetValorFormatado(decimal valor)
        {
            var cultureInfo = new CultureInfo("en-US");            
            return String.Format(cultureInfo, "{0:0.00}", valor);           
        }
    }
}
