﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine(Pow(2, 10));

int Pow(int num, int rank) // double long decimal float
{
    if (rank == 0)
    {
        return 1;
    }
    if (rank == 1)
    {
        return num;
    }
    // if (rank < 0)
    // {
    //     return (1 / (num * Pow(num, rank + 1)));
    // }
    return (num * Pow(num, rank - 1));
}
