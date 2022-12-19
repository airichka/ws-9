/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите число m: ");

if(uint.TryParse(Console.ReadLine(), out uint resultM))
{
    Console.Write("Введите число n: ");
    if(uint.TryParse(Console.ReadLine(), out uint resultN))
    {
        Console.Write($"m = {resultM}; n = {resultN} -> A(m, n) = {FuncAkkerman(resultM, resultN)}");
    }
}
else
{
    Console.WriteLine("Вы ввели не натуральное число");
}

static uint FuncAkkerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return FuncAkkerman(m - 1, 1);
    else
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}
