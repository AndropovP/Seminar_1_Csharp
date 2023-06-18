// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int numMax = 0; 
int numMin = 0;

if (num1 > num2)
{
    numMax = num1; numMin = num2;
}
else
{
    numMax = num2; numMin = num1;
}
Console.WriteLine($"Из двух введённых чисел: {num1} и {num2}");
Console.WriteLine($"Максимальным числом является: {numMax}");
Console.WriteLine($"Минимальным числом является: {numMin}");