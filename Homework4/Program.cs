using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //n цикл
        string a = "";
        int n = 201;
        while (n < 500) 
        {
            
            if (n % 17 == 0) 
            {
             a += n+",";
             ++n;
             
            }
            else;
            {
             
             ++n;
            
            } 
        
        }
        a = a.TrimEnd(',');
        Console.WriteLine(a);
    }



}
