using System;
using System.Collections.Generic;

namespace ConsoleToDoListChallenge
{
    class Program
    {
        private static List<string> todos = new List<string>();
         
        static void Main(string[] args)
        {

            MenuAcion currentAcion = MenuAcion.Help;
            string par = "";

            PrintHelp();
            do
            {   
                
                (currentAcion, par) = GetMenuAcion();

                Console.WriteLine();

                switch (currentAcion)
                {
                    case MenuAcion.Add:
                        AddToDo(par);
                        break;
                    case MenuAcion.Print:
                        Print(4);
                        break;
                    case MenuAcion.PrintAll:
                        Print();
                        break;
                    case MenuAcion.Done:
                        Done(par);
                        break;
                    case MenuAcion.Exit:
                        break;
                    case MenuAcion.Help:
                        PrintHelp();
                        break;
                    case MenuAcion.Clear:
                        Clear();
                        break;

                    default:
                        break;
                }

                Console.WriteLine();

            } while (currentAcion != MenuAcion.Exit);

            Console.ReadLine();
        }

        private static (MenuAcion acion, string par) GetMenuAcion()
        {
            MenuAcion acion = MenuAcion.Help;

            Console.WriteLine("Que vols fer: ");
            string fullacion = Console.ReadLine();
            
            string acionSt = fullacion;
            string par = "";

            if (fullacion.IndexOf(' ') >= 0)
            {
                acionSt = fullacion.Substring(0, fullacion.IndexOf(' '));
                par = fullacion.Substring(fullacion.IndexOf(' ') +1);
            }

            if (Enum.TryParse(acionSt, out acion) == false)
            {
                acion = MenuAcion.Help;
            }

            return (acion, par);
        }

        private static void Done(string todoNumber)
        {
            if (int.TryParse(todoNumber, out int todo))
            {
                todos.RemoveAt(todo);
            }
            else
            {
                Console.WriteLine("Es un nombre invalidad de item");
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("-------------------Menu---------------------");
            Console.WriteLine("Acions disponibles: ");
            Console.WriteLine("Add - Afegir un item a la llista");
            Console.WriteLine("Print - Imprimeix els 3 primers elements");
            Console.WriteLine("PrintAll - Imprimeix tots els elements");
            Console.WriteLine("Done - Completa un item");
            Console.WriteLine("ReOrder - Cambia l'ordre de tot");
            Console.WriteLine("Clear - Netetjar la pantalla");
            Console.WriteLine("Exit - Sortir de l'apliacio");
            Console.WriteLine("Help - Rep ajuda");
        }

        private static void AddToDo(string todo)
        {
            todos.Add(todo);
        }

        private static void Print(int count = 0)
        {
            if (count == 0 || count > todos.Count)
            {
                count = todos.Count;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ i }: { todos[i] }");
                
            }
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void ReOrder(String par)
        {
            string[] parSet = par.Split(' ');
            
            if (parSet.Length != 2)
            {
                Console.WriteLine("Has de passar nombres corectes per el parametre");
                return;
            }

            int from = 0;
            int to = 0;

            if (int.TryParse(parSet[0], out from) == false)
            {
                Console.WriteLine("Necessites pasar un nombre valid");
                return;
            }
            if (int.TryParse(parSet[1], out to) == false)
            {
                Console.WriteLine("Has de pasar un valor valid");
                return;
            }
            if (from < 0 || from > todos.Count - 1)
            {
                Console.WriteLine("From no es un nombre valid");
                return;
            }
            if (to < 0 || to > todos.Count - 1)
            {
                Console.WriteLine("To no es un nombre valid");
                return;
            }

            string todo = todos[from];
            todos.RemoveAt(from);
            todos.Insert(to, todo);
        }

    }

    public enum MenuAcion
    {
        Add,
        Print,
        PrintAll,
        Done,
        Exit,
        Help,
        Clear
    }
}
