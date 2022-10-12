// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// вводим число
int GetValue()
{
    Console.Write("Input number ");
    int result = Int32.Parse(Console.ReadLine());
    return result;
}


int SumElement(int x)
{
    int sum = 0;
    int o = 0;

    while (x != 0)
    {
        o = x % 10;
        x = x / 10;
        sum = sum + o;
    }
  
    return sum;
}

int n = GetValue();
int result = SumElement(n);
Console.WriteLine("The sum of elements = " + result);

