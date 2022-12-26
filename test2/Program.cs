// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.Clear();
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
System.Console.WriteLine("Введите размер массива M x N");
int m = inputNumber("М = ");
int n = inputNumber("N = ");
double[,] matrix = new double[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Math.Round(random.NextDouble() * 10, 2);
        System.Console.Write("\t| " + matrix[i, j]);
    }
    System.Console.Write("|");
    System.Console.WriteLine();
}
Console.WriteLine("Введите координаты массива");
R:
int a = inputNumber("Введите позицию элемента столбца: ");
int b = inputNumber("Введите позицию элемента строки: ");
if (a > m || b > n)
{
    Console.WriteLine("Такого числа в массиве нет! \nПопробуйте еще раз!");
    goto R;
}
else
{
    object c = matrix.GetValue(a, b);
    Console.WriteLine(c);
}