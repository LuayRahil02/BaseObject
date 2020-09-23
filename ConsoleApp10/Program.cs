using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en höjd");
            int höjd = int.Parse(Console.ReadLine());
            Console.WriteLine("Din höjd är " + höjd);
            Console.WriteLine("Skriv en Bredd");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Din höjd är " + bredd);
            string form;
            Console.WriteLine("vilken form vill du göra?");
            form = Console.ReadLine();
            if (form = rektangel)
            {
                Rectangle rec = new Rectangle(bredd, höjd);
                Console.WriteLine("Rektanglens arean är " + rec);
                Console.WriteLine("Rektanglens omkretsen är " + rec);
            }
            else if (form = triangel)
            {
                Triangle tri = new Triangle(bredd, höjd);
                Console.WriteLine("Trianglens arean är " + tri);
                Console.WriteLine("Trianglens omkretsen är " + tri);
            }

            else
            {
                Console.WriteLine("fel svar");

            }
    }
}
