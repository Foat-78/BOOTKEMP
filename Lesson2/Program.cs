//3. Линейные O(n) - Это когда алгоритм ваполняет действие n раз

// Напишите программу, которая принимает на вход одно число и возвращает сумму чисел от 1 до n.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), result = 0;
for (int i = 1; i <= n; i++)
    result += i;
Console.WriteLine($"Сумма число от 1 до {n} = {result}");