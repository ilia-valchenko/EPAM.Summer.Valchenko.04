using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath.Tests
{
    /// <summary>
    /// This class represents criterion for ascending sorting two-dimensional array by Min element of each row.
    /// </summary>
    class CompareByAscendingMinElement : IComparer<int[]>
    {
        /// <summary>
        /// This method equals two arrays by Min of elements in each row. 
        /// </summary>
        /// <param name="firstArray">The first of the arrays which must be compared</param>
        /// <param name="secondArray">The second of the arrays which must be compared</param>
        /// <returns>Returns 0 if min of elements of arrays element are equal. Returns -1 if min of element of the first elements more than another one.</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            int minElementOfFirstArray = firstArray.Length == 0 ? int.MinValue : firstArray.Min();
            int minElementOfSecondArray = secondArray.Length == 0 ? int.MinValue : secondArray.Min();

            if (minElementOfFirstArray == minElementOfSecondArray)
                return 0;

            if (minElementOfFirstArray < minElementOfSecondArray)
                return 1;
            else
                return -1;
        }
    }
}
