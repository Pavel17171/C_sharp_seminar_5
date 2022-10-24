// E03 Написать программу копирования массива


// Задаем исходные параметры для создания рандомного массива

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine();
Console.Write("Задайте нижнюю границу рандома: ");
int min = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine();
Console.Write("Задайте верхнюю границу рандома: ");
int max = int.Parse(Console.ReadLine() ?? "0");


// Создаем рандомный массив и выводим на экран

int[] array = new int[n];
Random rand = new Random();
Console.Write("Первоначальный массив: ");
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(min, max + 1);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();


// Создаем копию массива и выводим на экран

int[] arrayCopy = new int[array.Length];
Console.Write("Копия нашего массива:  ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.Write($"{arrayCopy[i]} ");
}