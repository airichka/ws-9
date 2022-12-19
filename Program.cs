/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите число M: ");

if (uint.TryParse(Console.ReadLine(), out uint resultM))
{
    Console.Write("Введите число N: ");
    if (uint.TryParse(Console.ReadLine(), out uint resultN))
    {
        Console.Write($"M = {resultM}; N = {resultN} -> {GetSum(resultM, resultN)}");
    }
}
else
{
    Console.WriteLine("Вы ввели не натуральное число");
}

static uint GetSum(uint m, uint n)
{
    uint sum = 0;

    foreach (var num in GetNumCollection(m, n))
    {
        sum += num;
    }

    return sum;
}

static IEnumerable<uint> GetNumCollection(uint m, uint n)
{
    var nums = new List<uint>();

    for (var i = m; i <= n; i++)
    {
        nums.Add(i);
    }

    return nums;
}
