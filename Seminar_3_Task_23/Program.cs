// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


double GetValue(string text)
{
    Console.Write("Input number " + text + ": ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double N = GetValue("N");

double Calculation(double N)
{
    double x = 1;
    double result = 0;
    Print();
    while (x <= N)
    {
        result = x * x * x;
        Console.Write(" " + result + ", ");
        x++;
    }
    return result;
}

void Print()
{
    string output = $"{N} ->";
    Console.Write(output);
}

Calculation(N);


