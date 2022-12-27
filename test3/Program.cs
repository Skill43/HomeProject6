// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
System.Console.WriteLine("Введите размер массив M x N");
int m = inputNumber("М = ");
int n = inputNumber("N = ");
int[,] matrix = new int[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(1, 10);
        System.Console.Write("\t| " + matrix[i, j]);
    }
    System.Console.Write("|");
    System.Console.WriteLine();
}
for (int i = 0; i < n; i++)

{
    double res = 0;
    for (int j = 0; j < m; j++)
    {
       res +=matrix[j,i];
    
        
    }
    System.Console.WriteLine("Среднее арифметическое столбца {0}: {1}",i, res/m);
}
