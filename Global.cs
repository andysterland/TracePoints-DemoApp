using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracePoint_DemoApp
{
    class Global
    {
        public static Random RandomGenerator = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Global.RandomGenerator.Next(s.Length)]).ToArray());
        }

        public static string RandomState()
        {
            return "WA";
        }
    }
}
