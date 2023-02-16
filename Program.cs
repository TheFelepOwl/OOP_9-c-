class Program
{
    static void Main(string[] args)
    {
        string str;
        double a,angle,b,c;
        int type; 

        Console.WriteLine("Input acute angle: ");
        str=Console.ReadLine();

        angle=Convert.ToSingle(str);

        Console.WriteLine("Do u have adjacent leg (input 0) or the opposite leg(input 1)? ");
        
        str = Console.ReadLine();
        type = Convert.ToInt32(str);   

        if(type == 0)
        {
            Console.WriteLine("Input a: ");
           
            str = Console.ReadLine();
            a =Convert.ToSingle(str);

            b = a / Math.Tan(angle);
            c = b / Math.Cos(angle);

            if (b < 0 || a < 0)
            {
                Console.WriteLine("Doesnt exist");
                System.Environment.Exit(0);
            }

            Console.WriteLine("Parties: " + a + " " + b + " " + c + "\n");
            Print(a, b, c);
        }
        
        else
        {
            Console.WriteLine("Input b: ");
            
            str=Console.ReadLine();
            b = Convert.ToSingle(str);

            a = b * Math.Tan(angle);
            c = b / Math.Cos(angle);

            if (b < 0||a<0)
            {
                Console.WriteLine("Doesnt exist");
                System.Environment.Exit(0);
            }
                

            Console.WriteLine("Parties: " + a + " " + b + " " + c + "\n");
            Print(a, b, c);
        }
    
        
    }


    static void Print(double a,double b, double c)
    {
        Console.WriteLine("Perimeter: " + P(a, b, c));
        Console.WriteLine("Area: " + S(a, b, c));

    }
    
    static double P(double a, double b, double c)
    {
        return a + b + c;
    }

    static double S(double a, double b, double c)
    {
        double p = P(a, b, c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}