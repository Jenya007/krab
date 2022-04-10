// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array = new string[] { "1", "2", "Russia", "+*-/4", "88" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Formation(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
    }
        else arr[i] = string.Empty;
    }
}
PrintArray(array);
Formation(array);
Console.Write("Результат: ");
PrintArray(array);