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
