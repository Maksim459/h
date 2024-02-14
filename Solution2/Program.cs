internal class Program
{
    private static void Main(string[] args)
    {
        const decimal Pi = 3.141592653m;
        Console.WriteLine("Введите величину радиуса:");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину:");
        double l = Convert.ToDouble(Console.ReadLine());
        double s = (double)Pi * r * (r + l);
        Console.WriteLine("Площадь поверхности равна {0}",s);
        Console.ReadKey();
        
    }
}