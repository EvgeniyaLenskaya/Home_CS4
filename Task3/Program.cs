// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int n = 8;
int [] array = new int [n];
Random arr = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = arr.Next(1, 9);

}
Console.WriteLine($"[{String.Join(", ", array)}]");