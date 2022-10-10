/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int b1 = ReadData("Введите координату b первой точки: ");
int k1 = ReadData("Введите координату k первой точки: ");
int b2 = ReadData("Введите координату b второй точки: ");
int k2 = ReadData("Введите координату k второй точки: ");

result(b1, k1, b2, k2);
double x = 0;
double y = 0;

void result(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}



