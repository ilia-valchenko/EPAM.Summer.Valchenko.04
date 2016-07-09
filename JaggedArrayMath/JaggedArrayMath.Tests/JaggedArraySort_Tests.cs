using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JaggedArrayMath.JaggedArraySort;

namespace JaggedArrayMath.Tests
{
    [TestClass]
    public class JaggedArraySort_Tests
    {
        [TestMethod]
        public void SortBySumOfRowElementsExpectedArraySortedByAscending()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22},
                new int[] {1}
            };
            int[][] expectedArray = new int[][]
            {
                new int[] {1},
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},               
            };

            Sort(jaggedArray, new SumOfRowElements());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void SortBySumOfRowElementsExpectedArraySortedByDescending()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22},
                new int[] {1}
            };
            int[][] expectedArray = new int[][]
            {
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {1}
            };

            Sort(jaggedArray, new SumOfRowElements(), false);

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void SortBySumOfRowElementsWithEmptyArraysExpectedArraySortedByAscending()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {},
                new int[] {11,22},
                new int[] {1},
                new int[] {}
            };
            int[][] expectedArray = new int[][]
            {
                new int[] {},
                new int[] {},
                new int[] {1},
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},
            };

            Sort(jaggedArray, new SumOfRowElements());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void SortByRowMaxElementExpectedArraySortedByAscending()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6,10},
                new int[] {11,22},
                new int[] {1}
            };
            int[][] expectedArray = new int[][]
            {
                new int[] {1},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6, 10},
                new int[] {11, 22},
            };

            Sort(jaggedArray, new RowMaxElement());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void SortByRowMinElementExpectedArraySortedByAscending()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6,10},
                new int[] {11,22},
                new int[] {1}
            };
            int[][] expectedArray = new int[][]
            {
                new int[] {0, 2, 4, 6, 10},
                new int[] {1, 3, 5, 7, 9},
                new int[] {1},               
                new int[] {11, 22}
            };

            Sort(jaggedArray, new RowMinElement());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        private bool IsEqualArrays(int[][] arr, int[][] brr)
        {
            if (arr.Length == brr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i].Length != brr[i].Length)
                        throw new ArgumentException("Arrays have different dimensions.");
                }
            }
            else throw new ArgumentException("Arrays have different dimensions.");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] != brr[i][j])
                        return false;
                }
            }

            return true;
        }
    }
}
