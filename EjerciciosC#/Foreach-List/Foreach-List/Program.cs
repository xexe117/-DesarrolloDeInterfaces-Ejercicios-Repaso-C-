using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>() { "Jhon", "Mary", "Sue", "Greg", "Yoolanda", "Jose", "Bill" };

            foreach (string nom in names)
                Console.WriteLine($"Hello " + nom);


            Console.WriteLine();

            List<PersonModel> peoplesModel = GetPersonModels();

            foreach (PersonModel nom in peoplesModel)
                Console.WriteLine($"Hello  { nom.FirstName } { nom.LastName }");

            Console.ReadLine();
        }
        private static List<PersonModel> GetPersonModels()
        {
            List<PersonModel> names = new List<PersonModel>();

            names.Add(new PersonModel { FirstName = "Tim", LastName = " Corey" });
            names.Add(new PersonModel { FirstName = "Bill", LastName = " McCoy" });
            names.Add(new PersonModel { FirstName = "Mary", LastName = " Tomas" });
            names.Add(new PersonModel { FirstName = "Sue", LastName = " Smith" });

            return names;
        }
    }
}
