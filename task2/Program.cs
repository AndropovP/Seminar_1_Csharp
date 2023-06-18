// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int numMax = num1;
if (numMax < num2)
{
    numMax = num2; 
}
if (numMax < num3)
{
    numMax = num3;
}
Console.WriteLine($"Из трёх введённых чисел: {num1}, {num2} и {num3}");
Console.WriteLine($"Максимальным числом является: {numMax}");