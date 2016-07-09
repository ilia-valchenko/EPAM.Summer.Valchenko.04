using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayMath
{
    /// <summary>
    /// ISortCriterion provides criteria for sorting. 
    /// </summary>
    public interface ISortCriterion
    {
        /// <summary>
        /// This methos defines by what criterion original array will be sorted.
        /// </summary>
        /// <param name="array">Row of original jagged array</param>
        int CriterionMethod(int[] array);
    }
}
