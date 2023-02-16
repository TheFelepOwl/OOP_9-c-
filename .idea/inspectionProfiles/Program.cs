
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string str;
        int x, y, z;

       
        
        


        while(true)
        {

            Console.WriteLine("Input X: ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if(x == 0)
                break;

            Console.WriteLine("Input Y: ");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);

            Console.WriteLine("Input Z: ");
            str = Console.ReadLine();
            z = Convert.ToInt32(str);






            Print(x, y, z);
        }

        

    }

    static void Print(int x, int y, int z)
    {
        Range(x);

        float res = Res_part(x, y, z);

        Console.WriteLine("Result: "+ res +"\n");

        Audit(res);
    }


    static void Audit(float x)
    {
        if (x >= 0)
            Console.WriteLine("The Value is positive");
        else
            Console.WriteLine("The Value is negative");
    }

    static void Range(int x)
    {
        if (x <= -10)
            Console.WriteLine("\nRange: x < -10");
        else if (x <= -1)
            Console.WriteLine("\nRange: x < -1");
        else if (x >= 1)
            Console.WriteLine("\nRange: x>1");
        else
            Console.WriteLine("\nRange: x>10");
    }

    static float Part_1(int x, int y, int z)
    {
        return (y - z) * (x - z);
    }

    static float Part_2(int x, int y)
    {
        return x+y;
    }

    static float Part_3(int x, int y)
    {
        return y - x;
    }

    static float Res_part(int x, int y, int z)
    {
        return  Part_3(x,y) * (  Part_1 (x, y, z) /  Part_2(x, y) );
    }

}