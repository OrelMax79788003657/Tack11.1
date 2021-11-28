using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tack11._1
{
    public struct Kxb
    {
        public float k;
        public float b;

        public Kxb(float newk, float newb)
        {
            this.k = newk;
            this.b = newb;
        }
        public void Root(out float x)
        {
            x = -b / k;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Линейное уравнение 0=kx+b");
            float x = 0;
            Console.Write("где коэффициент уравнения k = ");
            float k = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("и коэффициент уравнения b = ");
            float b = float.Parse(Console.ReadLine());

            Kxb kxb = new Kxb(k, b);
            kxb.Root(out x);

            Console.WriteLine();

            Console.Write("тогда x = ");
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
