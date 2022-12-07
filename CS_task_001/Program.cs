Console.Clear();

Console.Write("Для проверки числа на палиндром, введите его: ");
string a = Console.ReadLine();
int resultA = int.Parse(a);
int digitA = resultA;
int rev = 0;

while (resultA > 0)
{
    int count = (resultA % 10);
    rev = (rev * 10 + count);
    resultA = resultA / 10;
}
if (digitA == rev)
{
    Console.WriteLine("Введенное число - палиндром!");
}
else
{
    Console.WriteLine("Введенное число - не палиндром!");
}