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
            Console.WriteLine("Höjden är " + höjd);
            Console.WriteLine("Skriv en bredd");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Höjden är " + bredd);

            Triangle tri = new Triangle(bredd, höjd);
            Console.WriteLine("Arean är " + tri);
            Console.WriteLine("Omkretsen är " + tri);

            Rectangle rec = new Rectangle(bredd, höjd);
            Console.WriteLine("Arean är " + rec);
            Console.WriteLine("Omkretsen är " + rec);

        }
    }
}
