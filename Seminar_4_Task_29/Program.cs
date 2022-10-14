// Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




//int[] array = { 1, 2, 3 };



//array[0] = Int32.Parse(Console.Read());
Console.Write("Input quantity of elements for array: ");
int elements = Int32.Parse(Console.ReadLine());

void GetArray(int elements)
{
    int[] array = new int[elements];
    Console.WriteLine($"Input {elements} numbers");
    for (int index = 0; index <= (elements - 1); index++)
    {
        array[index] = Int32.Parse(Console.ReadLine());
    }

    Console.WriteLine("--> [" + string.Join(", ", array) + "]");
}

GetArray(elements);
