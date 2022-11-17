/*int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(array[3]);
// Сложность алгоритма О(1)
// Сложность алгоритма О(n)


int summa = 0;
for (int i = 0; i < n; i++)
{
    summa += array[i];
}
Console.WriteLine(summa);
*/
// O(n^2/2)
// Таблица умножения
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        {
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[i, j] = (i + 1) * (j + 1);
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        {
            Console.Write(matrix[i, j]);
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
