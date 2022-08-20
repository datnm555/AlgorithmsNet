using Algorithms_DataStruture_Lib;
using NUnit.Framework;

namespace Algorithms_DataStruct_Test
{
    [TestFixture]
    public class SortingTests
    {
        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new int[] { 1 };
            samples[1] = new int[] { 2, 1 };
            samples[2] = new int[] { 2, 1, 3 };
            samples[3] = new int[] { 1, 1, 1, };
            samples[4] = new int[] { 2, -1, 3, 3 };
            samples[5] = new int[] { 4, -5, 3, 3 };
            samples[6] = new int[] { 0, -5, 3, 3 };
            samples[7] = new int[] { 0, -5, 3, 0 };
            samples[8] = new int[] { 3, 2, 5, 5, 1, 0, 7, 8 };
            return samples;
        }

        private void RunTestForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("______TRACE_____\n");
            foreach (var el in array)
            {
                        TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n-------------------------\n");
        }


        [Test]
        public void BubbleSortValidInpuSortInput()
        {
            RunTestForSortAlgorithm(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSortValidInputSortInput()
        {
            RunTestForSortAlgorithm(Sorting.SelectionSort);
        }


    }
}