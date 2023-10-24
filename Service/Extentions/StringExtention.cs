using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Extentions
{
    public static class StringExtention
    {
        public static string ValidateString(this string data)
        {
            while (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Pleasa add valid value");
                data = Console.ReadLine();
            }
            return data;
        }
    }
}
