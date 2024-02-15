using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndString
{
    internal class JaggedArray
    {
        public void JagArray() 
        {
            int[][] y  = {
                new int[] { 2,21,23,12,12,32},
                new int[] { 2,21,2,31,32,12,43,1,43},
                new int[] { 2,21,43,64,2,1}
            };

            y[0][0] = 100;
            Console.WriteLine(y[0].Length);
            
        }
    }
}
