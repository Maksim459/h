internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите трехзначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        int b = number / 100;
        int a = number % 100;
        int a2 = a / 10;
        int a3 = a % 10;
        //b сотни
        //a десятки и единицы
        //a2 десятки
        //a3 единицы
        int b1 = b + a2 + a3;
        int b2 = b * a2 * a3;
        Console.WriteLine("число десятков в числе {0}", a2);
        Console.WriteLine("число единиц в числе {0}", a3);
        Console.WriteLine("сумма цифр данного числа {0}", b1);
        Console.WriteLine("произведение цифр данного числа {0}", b2);

        Console.ReadKey();
    }
}