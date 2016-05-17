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

        static void QuickSort(int[] array,int low,int high) 
        {
            if(low < high)
            {
                int privotLocation = partition(array, low, high);
                QuickSort(array, low, privotLocation-1);
                QuickSort(array, privotLocation +1, high);
            }
        }


        static int partition(int[] array,int low,int high) 
        {
            int privoKey = array[low];
            return 0;
        }

        static void swap(int a,int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
