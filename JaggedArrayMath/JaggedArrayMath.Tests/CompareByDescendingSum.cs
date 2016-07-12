using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath.Tests
{
    /// <summary>
    /// This class represents criterion for descending sorting two-dimensional array by sum of elements of each row.
    /// </summary>
    class CompareByDescendingSum : IComparer<int[]>
    {
        /// <summary>
        /// This method equals two arrays by sum of these elements. 
        /// </summary>
        /// <param name="firstArray">The first of the arrays which must be compared</param>
        /// <param name="secondArray">The second of the arrays which must be compared</param>
        /// <returns>Returns 0 if sums of arrays element are equal. Returns 1 if sum of element of the first elements more than another one.</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            int sumOfElementsOfFirstArray = firstArray.Length == 0 ? int.MinValue : firstArray.Sum();
            int sumOfElementsOfSecondArray = secondArray.Length == 0 ? int.MinValue : secondArray.Sum();

            if (sumOfElementsOfFirstArray == sumOfElementsOfSecondArray)
                return 0;

            if (sumOfElementsOfFirstArray < sumOfElementsOfSecondArray)
                return -1;
            else
                return 1;
        }
    }
}
