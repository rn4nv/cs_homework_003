Console.Clear();

Console.WriteLine("Данные для точки 'А'.");
Console.Write("Введите координату X для точки 'A': ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки 'A': ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Данные для точки 'B'.");
Console.Write("Введите координату X для точки 'B': ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки 'B': ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2 - x1)+(y2 - y1));

Console.Write("Расстояние между точками 'A' и 'B' равно: ");
Console.Write(Math.Round(result, 2));