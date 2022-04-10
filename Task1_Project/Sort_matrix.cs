namespace Project_Nazarov
{
    public class SortByBubble
    {
        public delegate bool Compare(int a, int b);//делегат который обеспечивает тип сравнения элементов: по возрастанию\убыванию
        public static bool Sort_Asc(int a, int b)//функция сравнения по возрастанию
        {
            return a < b;
        }
        public static bool Sort_Desk(int a, int b)//функция сравнения по убыванию
        {
            return a > b;
        }

        public delegate int Sort_Alg(ref int[,] matrix, int row);//делегат, отвечающий за тип сравнения
        public static int Max_El_Sort(ref int[,] matrix, int row)//по максимальному в строке
        {
            int max_el = matrix[row, 0];
            int columns = matrix.GetLength(1);
            for (int i = 1; i < columns; i++)
            {
                if (matrix[row, i] > max_el) max_el = matrix[row, i];
            }
            return max_el;
        }
        public static int Min_El_Sort(ref int[,] matrix, int row)//по минимальному в строке
        {
            int min_el = matrix[row, 0];
            int columns = matrix.GetLength(1);
            for (int i = 1; i < columns; i++)
            {
                if (matrix[row, i] < min_el) min_el = matrix[row, i];
            }
            return min_el;
        }
        public static int Sum_Row(ref int[,] matrix, int row)//по сумме внутри строки
        {
            int sum_el = 0;
            int columns = matrix.GetLength(1);
            for (int i = 0; i < columns; i++)
            {
                sum_el += matrix[row, i];
            }
            return sum_el;
        }
        public void Sort(ref int[,] matrix, Sort_Alg alg, Compare comp)//заполняю матрицу [rows,2] с номером строки исходной матрицы и сравниваемым элементом
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] My_Comp = new int[rows, 2];
            for (int i = 0; i < rows; i++)
            {
                My_Comp[i, 0] = i;
                My_Comp[i, 1] = alg(ref matrix, i);
            }
            int[,] Sort_matrix = new int[rows, columns];
            Condition_Sort(ref My_Comp, comp);
            Sort_With_My_Comp(ref My_Comp, ref matrix, ref Sort_matrix);
            matrix = Sort_matrix; 
        }
        private void Condition_Sort(ref int[,] MyComp, Compare comp)//сортирую матрицу пузырьком [rows,2] с номером строки исходной матрицы и сравниваемым элементом
        {
            int[] curr = new int[2];
            int rows = MyComp.GetLength(0);
            for (int i = rows-1; i >= 0; i--)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (comp(MyComp[i, 1], MyComp[j, 1]))
                    {
                        curr[0] = MyComp[i, 0];
                        curr[1] = MyComp[i, 1];
                        MyComp[i, 0] = MyComp[j, 0];
                        MyComp[i, 1] = MyComp[j, 1];
                        MyComp[j, 0] = curr[0];
                        MyComp[j, 1] = curr[1];
                    }
                }
            }
        }
        private void Sort_With_My_Comp(ref int[,] MyComp, ref int[,] matrix, ref int[,] Sort_matrix)//выставляю в возвращаемую матрицу строки в том порядке, как они получились в матрице [rows,2]
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int k = MyComp[i, 0];
                for (int j = 0; j < columns; j++) Sort_matrix[i, j] = matrix[(int)k, j];
            }
        }
    }
}

