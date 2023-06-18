// Задача 4. Напишите программу, которая принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int num = 2;
while (num <= numN)
{
    Console.WriteLine(num);
    num = num + 2;
}