using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath.Tests
{
    /// <summary>
    /// This class represents criterion for descending sorting two-dimensional array by Max element of each row.
    /// </summary>
    class ComparerByDescendingMaxElement : IComparer<int[]>
    {
        /// <summary>
        /// This method equals two arrays by sum of these elements. 
        /// </summary>
        /// <param name="firstArray">The first of the arrays which must be compared</param>
        /// <param name="secondArray">The second of the arrays which must be compared</param>
        /// <returns>Returns 0 if sums of arrays element are equal. Returns -1 if sum of element of the first elements more than another one.</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            int maxElementOfFirstArray = firstArray.Length == 0 ? int.MinValue : firstArray.Max();
            int maxElementOfSecondArray = secondArray.Length == 0 ? int.MinValue : secondArray.Max();

            if (maxElementOfFirstArray == maxElementOfSecondArray)
                return 0;

            if (maxElementOfFirstArray < maxElementOfSecondArray)
                return -1;
            else
                return 1;
        }
    }
}
