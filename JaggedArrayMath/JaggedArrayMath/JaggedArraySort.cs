using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    /// <summary>
    /// This method sorts the array for a given criterion.
    /// </summary>
    public static class JaggedArraySort
    {
        /// <summary>
        /// This method sorts jagged arrays by sum of elements in each row. 
        /// </summary>
        /// <param name="array">Array which have to be sorted</param>
        /// <param name="isAscendingSort">Parameter which is responsible for ascending or descending sort</param>
        public static void Sort(int[][] array, ISortCriterion sortCriterion, bool isAscendingSort = true)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (isAscendingSort)
                    {
                        if (sortCriterion.CriterionMethod(array[j]) < sortCriterion.CriterionMethod(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                    else
                    {
                        if (sortCriterion.CriterionMethod(array[j]) > sortCriterion.CriterionMethod(array[j - 1]))
                        {
                            int[] helper = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = helper;
                        }
                    }
                }
        }
    }
}
