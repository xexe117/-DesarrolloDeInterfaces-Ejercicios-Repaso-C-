using System;
using System.Data;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Introduce una fecha: ");
            String data = Console.ReadLine();

            DateTime dataAnterior = DateTime.ParseExact(data, "dd/MM/yyyy", null);

            Console.WriteLine("Han passado: " + diasPasats.Days + " dias");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Introduce una hora: ");
            String hora = Console.ReadLine();

      
            DateTime horaanterior = DateTime.ParseExact(hora, "HH:mm", null);

            TimeSpan tempspasat = DateTime.Now.Subtract(horaanterior);

            Console.WriteLine($"Han pasado des de las {hora} hasta ahora {tempspasat.Hours} {tempspasat.Minutes}");


        }
    }
}
