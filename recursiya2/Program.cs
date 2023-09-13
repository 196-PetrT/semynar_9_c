// Задача 67: Напишите программу, которая будет принимать на вход
//  число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine(Getsum(12345));

int Getsum(int num)
{
    if (num == 0)
    {
        return num;
    }
    return num % 10 + Getsum(num / 10);
}
