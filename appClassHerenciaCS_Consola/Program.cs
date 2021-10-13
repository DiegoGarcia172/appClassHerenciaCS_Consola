using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;

            a = new Punto2D(98, 76);

            Console.WriteLine(a.ToString());

            Punto2D b;

            b = new Punto2D(30, 21);

            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);

            Console.WriteLine("Distancia " + d);

            Punto3D c;

            c = new Punto3D(978, 976);

            Console.WriteLine(c.ToString());

            Punto3D e;
            e = new Punto3D(30, 21);

            Console.WriteLine(e.ToString());




            Console.ReadKey();
        }

    }
}
