//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);

if (N >= 10000 && N < 100000)
{
    int first = N.ToString()[0];
    int second = N.ToString()[1];
    int third = N.ToString()[2];
    int fourth = N.ToString()[3];
    int fifth = N.ToString()[4];
    if (first == fifth && second == fourth)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}




