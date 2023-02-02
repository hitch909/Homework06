//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
void Main()
{
    Console.Write("\n введите значение b1=\t");
    double b1 = Convert.ToDouble(Console.ReadLine()!);
    Console.Write("\n введите значение k1=\t");
    double k1 = Convert.ToDouble(Console.ReadLine()!);
    Console.Write("\n введите значение b2=\t");
    double b2 = Convert.ToDouble(Console.ReadLine()!);
    Console.Write("\n введите значение k2=\t");
    double k2 = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine();

    if (k1 != k2 && b1 != b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"точка пересечения прямых в координатах {x}, {y}");
    }
    else Console.WriteLine("прямые не пересекаются");
}
Main();


