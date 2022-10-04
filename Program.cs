using System;
using System.Collections;

namespace EstructuradeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Queue cola = new Queue();
            Console.WriteLine("ingrese una cadena de texto");
            cadena = Console.ReadLine();

            while (cadena != string.Empty)
            {
                cola.Enqueue(cadena);

                Console.WriteLine("ingrese la siguiente cadena de texto, si asi lo desea");
                Console.ReadLine();
            }
            while (cola.Count > 0)
            {
                Console.WriteLine((string)cola.Dequeue());
            }
           Console.ReadKey();
            
        }
    }
}
