using System;
namespace Uppgift2
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilken håll vill du omvandla Celsius till Fahrenheit eller Fahrenhet til celsius?");
            Console.WriteLine("1.Celsius till Fahrenheit");
            Console.WriteLine("2. Fahrenheit till celsius");
            int svar = int.Parse(Console.ReadLine());
            switch (svar)
            {
                case 1:
                    {
                        Console.WriteLine("Hur många grader faranheit ");
                        float celsius = float.Parse(Console.ReadLine());
                        Console.Write(+celsius + " celsius i fahrenheit är");
                        Fahrenheit(celsius);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hur många grader celsius");
                        float fahrenhet = float.Parse(Console.ReadLine());
                        Console.Write(+fahrenhet + " fharenheit i celsius är");
                        Celsius(fahrenhet);
                        break;
                    }
            }
        }
        static void Fahrenheit(float tal1)
        {
            double summa = tal1 * 1.8 + 32;
            Console.Write(" " + summa + ".");
        }
        static void Celsius(float tal2)
        {
            double summa = (tal2 - 32) / 1.8;
            Console.Write(" " + summa + ".");
        
        }
    }
}