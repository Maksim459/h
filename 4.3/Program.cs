internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[5];
        Random x = new Random();
        for (int i = 0; i < a.Length; ++i)
        {
            a[i] = x.Next(1, 100);
        }
        int b = 0;
    Flag:
        Console.WriteLine(a[b]);
        b++;
        if (b < a.Length)
        {
            goto Flag;
        }


    }

}