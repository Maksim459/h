internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("000\n010\n000\n");
        Console.WriteLine("введите символ ");
        string a = Console.ReadLine();
        a = a.ToLower();
        if (a == "a")
        {
            Console.WriteLine("000\n100\n000\n");
        }
        else if (a == "w")
        {

            Console.WriteLine("010\n000\n000\n");
        }
        else if (a == "s")
        {
            Console.WriteLine("000\n000\n010\n");
        }
        else if (a == "d")
        {
            Console.WriteLine("000\n001\n000\n");

        }
        else
        {
            Console.WriteLine("перемещений не надо");
        }

    }

}