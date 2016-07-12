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
    public static class JaggedArray
    {
        /// <summary>
        /// This method sorts jagged arrays by given criterion. 
        /// </summary>
        /// <param name="array">Array which have to be sorted</param>
        /// <param name="comparator">Criterion for sorting</param>
        public static void Sort(int[][] array, IComparer<int[]> comparator)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                    if (comparator.Compare(array[j], array[j - 1]) > 0)
                        SwapRowsOfArray(array, j, j - 1);
        }

        /// <summary>
        /// This method replaces two rows into two-dimensional array.
        /// </summary>
        /// <param name="array">Original array</param>
        /// <param name="numberOfFirstRow">Index of first row</param>
        /// <param name="numberOfSecondRow">Index of second row</param>
        private static void SwapRowsOfArray(int[][] array, int numberOfFirstRow, int numberOfSecondRow)
        {
            int[] helper = array[numberOfFirstRow];
            array[numberOfFirstRow] = array[numberOfSecondRow];
            array[numberOfSecondRow] = helper;
        }
    }
}
