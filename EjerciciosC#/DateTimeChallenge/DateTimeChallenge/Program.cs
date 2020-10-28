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

            DateTime dataAnterior = DateTime.ParseExact(data, "dd/MM/yyyy", null);//Entiendo que tengo que poner null por la hora pero no entiendo que no funcione sin el null.
            TimeSpan diasPasats = DateTime.Now.Subtract(dataAnterior);

            Console.WriteLine("Han passat: " + diasPasats.Days + " dies");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Introduce una hora: ");
            String hora = Console.ReadLine();


        }
    }
}
