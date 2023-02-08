using System;
Console.Clear();
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"куб чисел от 1 до {n} равен: ");
for(int i = 1; i <= n; i++)
{
    Console.Write(i*i*i + " ");

}

