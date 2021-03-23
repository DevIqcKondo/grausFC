using System;

namespace grausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double f=0;
            double c=0;
            Console.WriteLine("Convertendo graus Fahrenheit para graus Celsius. ");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.Write("Digite uma temperatura: ");
            f=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            c= (f-32)/1.8;
            Console.WriteLine("Tecle ENTER para ver o resultado.");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Temperatura convertida em Celcius é: "+c);
            Console.ResetColor();
            Console.Beep();
    
        }
    }
}
