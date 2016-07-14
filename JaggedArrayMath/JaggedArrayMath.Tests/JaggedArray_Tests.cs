using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JaggedArrayMath.Tests
{
    [TestClass]
    public class JaggedArray_Tests
    {
        [TestMethod]
        public void AscendingSortBySumOfRowElements()
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

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new CompareByAscendingSum());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void DescendingSortBySumOfRowElements()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {11, 22},
                new int[] {1}
            };

            int[][] expectedArray = new int[][]
            {
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {1}
            };

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new CompareByDescendingSum());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void AscendingSortByMaxElement()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1, 10, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {},
                new int[] {11, 22},
                new int[] {1},
                new int[] {}
            };

            int[][] expectedArray = new int[][]
            {
                new int[] {},
                new int[] {},
                new int[] {1},
                new int[] {0, 2, 4, 6},
                new int[] {1, 10, 5, 7, 9},
                new int[] {11, 22}
            };

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new CompareByAscendingMaxElement());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void DescendingSortByMaxElement()
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
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {1},
                new int[] {},
                new int[] {}
            };

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new ComparerByDescendingMaxElement());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void AscendingSortByMinElement()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6,10},
                new int[] {11,22},
                new int[] {1},
                new int[] {10,7},
            };

            int[][] expectedArray = new int[][]
            {
                new int[] {0,2,4,6,10},
                new int[] {1,3,5,7,9},
                new int[] {1},
                new int[] {10,7},
                new int[] {11,22}
            };

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new CompareByAscendingMinElement());

            Assert.IsTrue(IsEqualArrays(jaggedArray, expectedArray));
        }

        [TestMethod]
        public void DescendingSortByMinElement()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6,10},
                new int[] {11,22},
                new int[] {1},
                new int[] {10,7},
            };

            int[][] expectedArray = new int[][]
            {
                new int[] {11,22},
                new int[] {10,7},
                new int[] {1,3,5,7,9},
                new int[] {1},
                new int[] {0,2,4,6,10}
            };

            JaggedArrayBasedOnComparer.Sort(jaggedArray, new CompareByDescendingMinElement());

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
