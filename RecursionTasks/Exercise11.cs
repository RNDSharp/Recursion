using System;

namespace RecursionTasks
{
    public static class Exercise11
    {
        // Дано число n, цифры которого не содержат нулей.
        // Получите число, записанное теми же цифрами,
        // но в противоположном порядке.
        // При решении этой задачи нельзя использовать циклы, строки, списки, массивы,
        // разрешается только рекурсия и целочисленная арифметика.
        public static long Run(long n)
        {
            return RunInternal(n, 0);
        }

        private static long RunInternal(long n, int i)
        {
            throw new NotImplementedException();
        }
    }
}
