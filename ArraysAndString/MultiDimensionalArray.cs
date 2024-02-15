using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndString
{
    internal class MultiDimensionalArray
    {
        public void MultiDimenArray() 
        {
            int[,] array = new int[2,3];
            Console.WriteLine("Multi Dimensional Array:");

            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                    list.Add(array[i, j]);
                }
            }

            string result = string.Join(",", list);
            Console.WriteLine(result);
        }
    }
}
