using System;
using System.Collections.Generic;
using System.Linq;

namespace PresekSetova
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>() {"Beograd", "Nis", "Kragujevac", "Subotica", "Novi Sad"};
            Console.WriteLine("HashSet<string> gradovi Pre intersectWith");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("===============================");

            string[] gradoviNaSeveru = {"Novi Sad", "Subotica"};
            var noviGradovi = gradovi.Intersect(gradoviNaSeveru);
            Console.WriteLine("noviGradovi nakon Intersect-a");
            foreach (var grad in noviGradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("===============================");
            
            Console.WriteLine("HashSet<string> gradovi Nakon Intersect");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("===============================");
            
            gradovi.IntersectWith(gradoviNaSeveru);
            Console.WriteLine("HashSet<string> gradovi Nakon IntersectWith-a");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("===============================");
        }
    }
}