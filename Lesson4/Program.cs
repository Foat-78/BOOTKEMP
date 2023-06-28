// 5. Квадратичные O(n ^ 2) - это когда запускаем цикл внутри друго цикла (пузырковая сортировка заключается выбор пару элементов и сравниваем его на последовательность
//  расположения т.е они должны стоять по возрастанию иначе мы их меняем местами)

// Алгорит пузырьковой сортировки
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-20, 21); // [-20; 20]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // string.Join - функция которая соединяет все элементы  массива и выводит в одну строку 
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1 - i; j++)
    {
        if (array[j] > array[j + 1])
            (array[j], array[j + 1]) = (array[j + 1], array[j]);
    }
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
// [-6, 4, 3, -9, 11]
// [-6, 3, -9, 4, 11]