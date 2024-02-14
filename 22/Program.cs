internal class Program
{
    private static void Main(string[] args)
    {
        bool a = true;
        while (a)
        {
            Flag:
            Console.WriteLine("Введите число длиной не больше 10 символов: ");
            string input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
                int d = number%2;
                if(d==1)
                {
                    Console.WriteLine("{0} это нечетное число",number);
                }
                else
                {
                    Console.WriteLine("{0} это четное число",number);
                }
                a = false;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение.Попробуйте снова");
                goto Flag;
            }
       
        }
        Console.ReadKey();
    
    }
}  
