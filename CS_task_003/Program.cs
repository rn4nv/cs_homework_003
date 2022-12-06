Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
double i = 1;

while (i <= n)
{
    double result = Math.Pow(i,3);
    Console.WriteLine(result);
    i++;
}
