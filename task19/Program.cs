Console.Clear();
Console.Write("Введите 5-значное число: ");
string s = Console.ReadLine();
if ((s.Trim()).Length != 5) 
{
    Console.WriteLine("Вы ввели не 5-значное число, введите 5-значное число: ");
    s = Console.ReadLine();
}
string s2 = s.Trim();
if(s2[0] == s2[4] && s2[1] == s2[3])
{
    Console.WriteLine($"Введенное число {s2} является палиндромом.");
}
else 
    Console.WriteLine($"Введенное число {s2} не является палиндромом.");

