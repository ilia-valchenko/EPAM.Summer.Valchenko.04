using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    /// <summary>
    /// This class represents criterion for ascending sorting two-dimensional array by Max element of each row.
    /// </summary>
    public class CompareByAscendingMaxElement : IComparer<int[]>
    {
        /// <summary>
        /// This method equals two arrays by Max of elements of each row. 
        /// </summary>
        /// <param name="firstArray">The first of the arrays which must be compared</param>
        /// <param name="secondArray">The second of the arrays which must be compared</param>
        /// <returns>Returns 0 if Max of arrays element are equal. Returns -1 if Max of element of the first elements more than another one.</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            int maxElementOfFirstArray = firstArray.Length == 0 ? int.MinValue : firstArray.Max();
            int maxElementOfSecondArray = secondArray.Length == 0 ? int.MinValue : secondArray.Max();

            if (maxElementOfFirstArray == maxElementOfSecondArray)
                return 0;

            if (maxElementOfFirstArray < maxElementOfSecondArray)
                return 1;
            else
                return -1;
        }
    }
}
