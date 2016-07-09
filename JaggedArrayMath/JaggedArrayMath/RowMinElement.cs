using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    public class RowMinElement : ISortCriterion
    {
        /// <summary>
        /// This method finds min of elements 
        /// </summary>
        /// <param name="array">Array is represented by elements from row in original jagged array</param>
        /// <returns>Return min of elements</returns>
        public int CriterionMethod(int[] array)
        {
            int result = 0;

            if (array.Length == 0)
                result = Int32.MinValue;

            if (array.Length >= 1)
                result = array[0];

            for (int i = 1; i < array.Length; i++)
                if (array[i] < result)
                    result = array[i];

            return result;
        }
    }
}
