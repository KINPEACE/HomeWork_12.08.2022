// Напишите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве.

int x1 = num("X", "A");
int y1 = num("Y", "A");
int z1 = num("Z", "A");
int x2 = num("X", "B");
int y2 = num("Y", "B");
int z2 = num("Z", "B");

int num(string coord, string point)
{
    Console.Write($"Введите координату {coord} точки {point}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double num1(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z1 - z2), 2));
}
double num2 = Math.Round (num1(x1, x2, y1, y2, z1, z1), 2);

Console.WriteLine($"Длина растояния {num2}");