// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// 1. Ввод координат
// 2. Расчет
// 3. Вывод 

double GetCoordinate(string text)
{
    Console.Write("Введите координату " + text + ": ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double ax = GetCoordinate("ax");
double ay = GetCoordinate("ay");
double az = GetCoordinate("az");
double bx = GetCoordinate("bx");
double by = GetCoordinate("by");
double bz = GetCoordinate("bz");


double GetDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    double dist = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
    return dist;
}

double result = GetDistance(ax, ay, az, bx, by, bz);
// Console.WriteLine(result);

// A (3,6,8); B (2,1,-7), -> 15.84

void Print()
{
    // string output = "A (" + ax + ", " + ay + ", " + az + "); B (" + bx + ", " + by+ ", " + bz +"), -> "+ Math.Round(result, 2);
    
    string output = $"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {Math.Round(result, 2)}";
    Console.WriteLine(output);

}

Print();
