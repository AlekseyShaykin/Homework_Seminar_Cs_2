// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int GetValue()
{
    Console.Write("Input number: ");
    int N = Int32.Parse(Console.ReadLine());
    return N;
}

int Lenght(int N)
{
    int count = 1;
    while (N > 1)
    {
        N = N / 10;
        count++;
    }
    Console.WriteLine("Lenght =" + count);
    return count;
}

// int L = Lenght(GetValue());
// if (L > 5) Console.WriteLine("!!! Input number consists more than 5 elements");
// if (L < 5) Console.WriteLine("!!! Input number consists less than 5 elements");

int Method(int N)
{
    int result = 0;
    int o = 0;

    while (N != 0)
    {
        o = N % 10;
        N = N / 10;
        result = result * 10 + o;
    }
    //Console.WriteLine(result);
    return result;
}

void Check(int N, int result)
{
    if (result == N)
    {
        Console.WriteLine($"{N} -> да");
    }
    else
    {
        Console.WriteLine($"{N} -> нет");
    }
}


int N = GetValue();
int x = Method(N);
Check(N,x);