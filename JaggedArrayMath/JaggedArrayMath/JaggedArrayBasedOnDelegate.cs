using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    /// <summary>
    /// This static class provides method which sorts jagged arrays by given criterion.
    /// </summary>
    public class JaggedArrayBasedOnDelegate
    {
       /// <summary>
       /// This method sorts jagged arrays by given criterion. 
       /// </summary>
       /// <param name="array">Array which have to be sorted.</param>
       /// <param name="comparisonMethod">Criterion for sorting.</param>
       public static void Sort(int[][] array, Func<int[], int[], int> comparisonMethod)
       {
           for (int i = 0; i < array.Length; i++)
               for (int j = array.Length - 1; j > i; j--)
                   if (comparisonMethod(array[j], array[j - 1]) > 0)
                       SwapRowsOfArray(ref array[j], ref array[j-1]);
        }

       /// <summary>
       /// This method sorts jagged arrays by given criterion method as second argument.
       /// </summary>
       /// <param name="array">Array which have to be sorted.</param>
       /// <param name="comparator">Criterion for sorting.</param>
       public static void Sort(int[][] array, IComparer<int[]> comparator) => Sort(array, comparator.Compare);

        /// <summary>
        /// This method replaces two rows into two-dimensional array.
        /// </summary>
        /// <param name="firstRow">First row</param>
        /// <param name="secondRow">Second row</param>
        private static void SwapRowsOfArray(ref int[] firstRow, ref int[] secondRow)
        {
            int[] buffer = firstRow;
            firstRow = secondRow;
            secondRow = buffer;
        }
    }
}
