using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class ArrayHelper
    {
        public static void print<T>(T[] array) 
        {
            string printStr = "";
            Array.ForEach<T>(array, (T t) => { printStr += t.ToString() + ","; });
            printStr = printStr.Trim(',');
            Console.WriteLine(printStr); 
        }
    }
}
