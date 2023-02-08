Console.Clear();
Console.WriteLine("Введите координаты первой точки x1, y1 и z1:  ");
Console.Write("Введите x1:  ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y1:  ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите z1:  ");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки x2, y2 и z2:  ");
Console.Write("Введите x2:  ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y2:  ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите z2:  ");
double z2 = double.Parse(Console.ReadLine()!);

double S = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

Console.WriteLine("Расстояние между двумя точками:  " + Math.Round(S, 2)); 
