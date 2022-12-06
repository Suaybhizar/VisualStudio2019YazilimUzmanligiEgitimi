using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.WebUI.Helpers
{
    public static class MvcHelper
    {
       public static string UrlHelper(string str)
        {
            return str.ToLower()
                 .Trim().
                 Replace("ç", "c")
                 .Replace("ğ", "g")
                 .Replace("ı", "i")
                 .Replace("ş", "s")
                 .Replace("ö", "o")
                 .Replace("ü", "u")
                 .Replace(" ", "")
                 .Replace("/", "");
        }
    }
}
