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

            Console.WriteLine("Triangeln:");
            Triangle tri = new Triangle(bredd, höjd);
            Console.WriteLine("Arean är " + tri.Area());
            Console.WriteLine("Omkretsen är " + tri.Circumferance());

            Console.WriteLine("Rektangeln: ");
            Rectangle rec = new Rectangle(bredd, höjd);
            Console.WriteLine("Arean är " + rec.Area());
            Console.WriteLine("Omkretsen är " + rec.Circumferance());

        }
    }
}
