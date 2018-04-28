using System;

class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
       
        Box box = new Box(lenght,width,height);
        Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());
        Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());
        Console.WriteLine("Volume - {0:F2}", box.Volume());
    }
}
