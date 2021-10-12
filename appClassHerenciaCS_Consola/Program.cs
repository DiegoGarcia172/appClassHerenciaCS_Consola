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
      a = new Punto2D(98,76);
      Console.WriteLine(a.ToString());

      Punto3D b;
      b = new Punto3D(55, 30);

      Console.WriteLine(b.ToString());


      Console.ReadKey();



    }
  }
}
