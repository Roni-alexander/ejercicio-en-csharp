using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.WriteLine("ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("su nombre y su edad es:"+nombre);
            Console.WriteLine("la edad es: "+edad);

            Console.ReadKey();
        }
    }
}
