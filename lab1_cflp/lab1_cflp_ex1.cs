using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        int sum = 0;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("suma = " + sum);
    }
}