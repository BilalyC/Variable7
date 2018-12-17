using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            double ab, bc, ca;
            Console.WriteLine("Etant donné que le triangle est rectangle en c, veuillez donner les valeur de bc et ca : ");
            bc = double.Parse(Console.ReadLine());
            Console.WriteLine("bc = " + bc);
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine("ca = " + ca);

            double carre = Math.Pow(bc,2) + Math.Pow(ca,2);
            ab = Math.Sqrt(carre);

            Console.WriteLine("AB étant l'hypothénuse, sa valeur est la racine carrée de la somme du carré de BC et du carré de CA :");
            Console.WriteLine("bc^2 + ca^2 = " + carre);
            Console.WriteLine("ab = " + ab);
        }
    }
}
