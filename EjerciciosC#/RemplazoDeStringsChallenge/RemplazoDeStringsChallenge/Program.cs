using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RemplazoDeStringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pirmerString = File.ReadAllLines(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt").ToList();

            Console.WriteLine("Itrodueix el text que vulguis remplacar: ");
            String remplac = Console.ReadLine();

            Console.WriteLine("Itrodueix el text que vulguis introduir: ");
            String intro = Console.ReadLine();

            for (int i = 0; i < pirmerString.Count; i++)
            {
                pirmerString[i] = pirmerString[i].Replace(remplac, intro);
            }

            File.WriteAllLines(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt", pirmerString);

            Console.WriteLine("El text ha sigut modificiat");


        }

        private static void Bonus()
        {
            //Mateixa ruta ja que només tenim un arxiu per descargar
            string bonusTxt = File.ReadAllText(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt");
            Dictionary<string, string> rempleacos = new Dictionary<string, string>();

            var resultats = Regex.Matches(bonusTxt, @"{[^{}]+}")
                .Cast<Match>()
                .Select(x => x.Value.Substring(1, x.Value.Length - 2))
                .ToHashSet();

            foreach (var result in resultats)
            {
                Console.WriteLine($"Introdueix el valor de { result }: ");
                bonusTxt = bonusTxt.Replace("{" + result + "}", Console.ReadLine());
            }

            File.WriteAllText(@"C:\Users\xesc2\Desktop\C#\-DesarrolloDeInterfaces-Ejercicios-Repaso-C-\EjerciciosC#\TextFileChallenge\Searching4Data_primary.txt", bonusTxt);

            Console.WriteLine("El text ha sigut modificiat");
        }
    }
}
