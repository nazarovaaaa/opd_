using NUnit.Framework;
using Project_Nazarov;

namespace OPD_tests_task1
{
    public class SortMachineTest
    {

        int[,] matrix = { { 1, 3, 5 }, { 6, -2, 7 }, { 11, 4, 0 } };
        SortByBubble sort = new SortByBubble();
        bool TestMatrix(int[,] matrix1, int[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [Test]
        public void MatrixMaximumDesc()
        {
            int[,] assertMatrix = { { 1, 3, 5 }, { 6, -2, 7 }, { 11, 4, 0 } };
            sort.Sort(ref matrix, SortByBubble.Max_El_Sort, SortByBubble.Sort_Asc);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }

        [Test]
        public void MatrixMaximumAsk()
        {
            int[,] assertMatrix = { { 11, 4, 0 }, { 6, -2, 7 }, { 1, 3, 5 } };
            sort.Sort(ref matrix, SortByBubble.Max_El_Sort, SortByBubble.Sort_Desk);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }

        [Test]
        public void MatrixMinimumAsk()
        {
            int[,] assertMatrix = { { 1, 3, 5 }, { 11, 4, 0 }, { 6, -2, 7 } };
            sort.Sort(ref matrix, SortByBubble.Min_El_Sort, SortByBubble.Sort_Desk);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }
        [Test]
        public void MatrixMinimumDesk()
        {
            int[,] assertMatrix = { { 6, -2, 7 }, { 11, 4, 0 }, { 1, 3, 5 } };
            sort.Sort(ref matrix, SortByBubble.Min_El_Sort, SortByBubble.Sort_Asc);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }

        [Test]
        public void MatrixSummaryAsk()
        {
            int[,] assertMatrix = { { 11, 4, 0 }, { 6, -2, 7 }, { 1, 3, 5 } };
            sort.Sort(ref matrix, SortByBubble.Sum_Row, SortByBubble.Sort_Desk);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }
        [Test]
        public void MatrixSummaryDesk()
        {
            int[,] assertMatrix = { { 1, 3, 5 }, { 6, -2, 7 }, { 11, 4, 0 } };
            sort.Sort(ref matrix, SortByBubble.Sum_Row, SortByBubble.Sort_Asc);
            Assert.IsTrue(TestMatrix(matrix, assertMatrix));
        }
    }
}