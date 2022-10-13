// Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без math.pow

int GetValue(string text)
{
    Console.Write("Input number " + text);
    int N = Int32.Parse(Console.ReadLine());
    return N;
}



int Degree(int N, int D)
{

    int res = N;
    while (D != 1)
    {
        D = (D - 1);
        res = res * N;
    }
        return res;
}

void Print (int A, int B, int result)
{
    string output = $"{A}, {B} -> {result}";
    Console.WriteLine(output);
}


int A = GetValue("A :");
int B = GetValue("B :");
int result = Degree(A, B);

Print(A, B, result);
