using System;
class Program
{
    static void Main(string[] args)
    {
        int a,b,c,delta;
        float x1,x2;
        Console.WriteLine("a,b,c = ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        delta = (b*b) - (4*a*c);
        if(delta > 0)
        {
            x1 = (-b + Math.Sqrt(delta))/(2*a);
            x2 = (-b - Math.Sqrt(delta))/(2*a);

            Console.WriteLine("delta > 0 \nprima solutie = " + x1 + "\na doua solutie = " + x2);
        }
        else
            if(delta == 0)
            {
                x1 = (-b)/(2*a); 
                Console.WriteLine("delta = 0\navem o singura solutie x = " + x1);
            }
            else
                Console.WriteLine("delta < 0\necuatia nu are solutii intregi");

    }
}