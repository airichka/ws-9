/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число: ");

if(uint.TryParse(Console.ReadLine(), out uint result))
{
 Console.Write($"N = {result} -> ");
 WriteNums(result);
}
else
{
 Console.WriteLine("Вы ввели не натуральное число");
}

uint WriteNums(uint n)
{
 if (n > 1)
 {
 Console.Write($"{n}, ");
 return WriteNums(--n);
 }

 Console.Write(n);
 return n;
}