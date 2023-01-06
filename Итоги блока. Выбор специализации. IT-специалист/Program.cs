// Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно
//   ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//   При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
Console.WriteLine("введите размер массива");
try
{
int size = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[size];
string[] res = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"введите элемент массива {i + 1}");
    arr[i] = Console.ReadLine();
}
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
CutMass(arr, res);
Console.WriteLine("Результирующий массив: ");
PrintArray(res); 
}
catch 
{
    
    Console.WriteLine("Размер массива задан в неверном формате (не число)");
}


//Запись в массив res элементов из массива arr с длиной не более 3 символов
void CutMass(string[] arr, string[] res)
{
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[k] = arr[i];
            k=k+1;
        }
    }
}

//Вывод на экран массива
void PrintArray(string[] array)
{
    foreach (string el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
