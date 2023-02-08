Console.Clear();
Console.WriteLine("Введите количество ягод на каждом кусте, разделяя пробелами, заканчивая <Enter> кустов должно быть больше 3х: ");
Console.WriteLine("Например 9 1 2 3 4 5 6 7 8...");
string berriesString = Console.ReadLine();
string[] berriesArrayString = berriesString.Split(' ');
int[] berriesArrayInt = new int[berriesArrayString.Length];
for(int i = 0; i < berriesArrayString.Length; i++)
{
    berriesArrayInt[i] = Convert.ToInt32(berriesArrayString[i]);
}
int max3 = berriesArrayInt[berriesArrayInt.Length-1] + berriesArrayInt[0] + berriesArrayInt[1];
int index = 0, berr = berriesArrayInt[0];
int sum3 = 0;
for(int j = 1; j < berriesArrayInt.Length - 2; j++)
{
    sum3 = berriesArrayInt[j-1] + berriesArrayInt[j] + berriesArrayInt[j+1];
    if (sum3 > max3)
    {
        max3 = sum3;
        index = j;
        berr = berriesArrayInt[j];
    }
}
sum3 = berriesArrayInt[berriesArrayInt.Length - 2] + berriesArrayInt[berriesArrayInt.Length - 1] + berriesArrayInt[0];
if (sum3 > max3)
{
        max3 = sum3;
        index = berriesArrayInt.Length - 1;
        berr = berriesArrayInt[berriesArrayInt.Length - 1];
}
Console.WriteLine($"Максимальное количество ягод будет {max3}, если начать с куста позиции {index}, на котором {berr} ягод, начиная с нулевого.");

