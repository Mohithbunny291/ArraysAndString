using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndString
{
    internal class SingleDimensionalArray
    {
        public void SingleDimenArray()
        {
            int[] array = new int[10]; //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Single Dimensional Array:");
           // foreach (int i in array) { Console.WriteLine(i); }
           for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                //Console.WriteLine(array[i] + " ");
            }
            
            string result = string.Join(",", array);

            // Print the resulting string in a single line
            Console.WriteLine(result);
        }
    }
}
