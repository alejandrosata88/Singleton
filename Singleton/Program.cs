using Singleton.Servicio;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Unico s1 = Unico.ObtenerInstancia();
            Unico s2 = Unico.ObtenerInstancia();

            if(s1==s2)
                Console.WriteLine("Patron singleton funciono");
            else
                Console.WriteLine("Patron singleton fallo");

            Console.ReadLine();
        }
    }
}
