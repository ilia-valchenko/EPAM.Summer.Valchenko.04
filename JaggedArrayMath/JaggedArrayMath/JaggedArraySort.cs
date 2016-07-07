using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    /// <summary>
    /// JaggedArraySort provides some of sorting methods for jagged arrays.
    /// </summary>
    public static class JaggedArraySort
    {
        #region sorting mathods for jagged arrays
        /// <summary>
        /// This method sorts jagged arrays by sum of elements in each row. 
        /// </summary>
        /// <param name="array">Array which have to be sorted</param>
        /// <param name="isAscendingSort">Parameter which is responsible for ascending or descending sort</param>
        public static void SortBySumOfRowElements(int[][] array, bool isAscendingSort = true)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (isAscendingSort)
                    {
                        if (GetSumOfRowElements(array[j]) < GetSumOfRowElements(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                    else
                    {
                        if (GetSumOfRowElements(array[j]) > GetSumOfRowElements(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                }
        }

        /// <summary>
        /// This method sorts jagged arrays by max element in each row. 
        /// </summary>
        /// <param name="array">Array which have to be sorted</param>
        /// <param name="isAscendingSort">Parameter which is responsible for ascending or descending sort</param>
        public static void SortByRowMaxElement(int[][] array, bool isAscendingSort = true)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (isAscendingSort)
                    {
                        if (GetRowMaxElement(array[j]) < GetRowMaxElement(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                    else
                    {
                        if (GetRowMaxElement(array[j]) > GetRowMaxElement(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                }
        }

        /// <summary>
        /// This method sorts jagged arrays by min element in each row. 
        /// </summary>
        /// <param name="array">Array which have to be sorted</param>
        /// <param name="isAscendingSort">Parameter which is responsible for ascending or descending sort</param>
        public static void SortByRowMinElement(int[][] array, bool isAscendingSort = true)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (isAscendingSort)
                    {
                        if (GetRowMinElement(array[j]) < GetRowMinElement(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                    else
                    {
                        if (GetRowMinElement(array[j]) > GetRowMinElement(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                }
        } 
        #endregion

        #region private helper methods which are used in sorted methods
        /// <summary>
        /// This method finds sum of elements 
        /// </summary>
        /// <param name="row">Array of element</param>
        /// <returns>Return sum of elements</returns>
        private static int GetSumOfRowElements(int[] row)
        {
            int result = 0;

            if (row.Length == 0)
                result = Int32.MinValue;

            for (int i = 0; i < row.Length; i++)
                result += row[i];

            return result;
        }

        /// <summary>
        /// This method finds max of elements 
        /// </summary>
        /// <param name="row">Array of element</param>
        /// <returns>Return max of elements</returns>
        private static int GetRowMaxElement(int[] row)
        {
            int result = 0;

            if (row.Length == 0)
                result = Int32.MinValue;

            if (row.Length >= 1)
                result = row[0];

            for (int i = 1; i < row.Length; i++)
                if (row[i] > result)
                    result = row[i];

            return result;
        }

        /// <summary>
        /// This method finds min of elements 
        /// </summary>
        /// <param name="row">Array of element</param>
        /// <returns>Return min of elements</returns>
        private static int GetRowMinElement(int[] row)
        {
            int result = 0;

            if (row.Length == 0)
                result = Int32.MinValue;

            if (row.Length >= 1)
                result = row[0];

            for (int i = 1; i < row.Length; i++)
                if (row[i] < result)
                    result = row[i];

            return result;
        } 
        #endregion
    }
}
