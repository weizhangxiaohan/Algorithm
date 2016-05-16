using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,4,6,2,5,9,7,3,8 };
            Util.ArrayHelper.print<int>(array);
            Array.Sort(array);
            Util.ArrayHelper.print<int>(array);
            Console.ReadKey();
        }
    }
}
