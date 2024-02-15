using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionalArray singleDimensionalArray = new SingleDimensionalArray();
            singleDimensionalArray.SingleDimenArray();

            MultiDimensionalArray multiDimensionalArray = new MultiDimensionalArray(); 
            multiDimensionalArray.MultiDimenArray();

            JaggedArray jaggedArray = new JaggedArray();
            jaggedArray.JagArray();
        }
    }
}
