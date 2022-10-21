using System;
using System.Collections;

namespace EstructuradeDatos
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Cola
            //string cadena;
            //Queue cola = new Queue();
            //Console.WriteLine("ingrese una linea de texto");
            //cadena = Console.ReadLine();

            //while (cadena != string.Empty)//mientras que la variable cadena sea distinta de un string vacio, que itere.
            //{
            //    cola.Enqueue(cadena);

            //    Console.WriteLine("ingrese la siguiente linea de texto, si asi lo desea");
            //    cadena = Console.ReadLine();
            //}
            //while (cola.Count > 0)
            //{
            //    Console.WriteLine((string)cola.Dequeue());
            //}
            //Console.ReadKey();

            #endregion
            #region Pila
            //string palabra;
            //Stack miPila = new Stack();
            //Console.WriteLine("ingrese una palabra");
            //palabra = Console.ReadLine();
            //while (palabra != "")
            //{
            //    miPila.Push(palabra);
            //    Console.WriteLine("Ingrese la próxima palabra");
            //    palabra = Console.ReadLine();
            //}
            //while (miPila.Count > 0)
            //{
            //    Console.WriteLine((string)miPila.Pop());
            //}
            ////////////ejercitacion propia, no corresponde a la tarea asignada////////////
            //foreach (string word in miPila) //muestra 3 veces.
            //{
            //    Console.WriteLine("\nmiPila.Contains(\"Soy\") = {0}", miPila.Contains("soy"));
            //}
            //Console.WriteLine("En la pila, ahora hay ");
            //foreach (string word in miPila)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadKey();
            #endregion
            #region arraylist
            //int numero;
            //ArrayList Lista = new ArrayList();
            //Console.WriteLine("Ingrese una palabra");
            //palabra = Console.ReadLine();
            //while (palabra != "")
            //{
            //    Lista.Add(palabra);
            //    Console.WriteLine("Ingrese la próxima palabra");
            //    palabra = Console.ReadLine();
            //}
            //Console.WriteLine("Ingrese la posición de la palabra que desea ver");
            //numero = int.Parse(Console.ReadLine());
            //while (numero != 0)
            //{
            //    if (numero <= Lista.Count && numero > 0)//la segunda condicion, es para prevenir num negativos. si no existiese se podria usar una excepcion?
            //    {
            //        numero--;
            //        Console.WriteLine((string)Lista[numero]);
            //        Console.WriteLine("Ingrese la posición de la palabra que desea");
            //        numero = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("La posición no existe \n Ingrese otra posición");
            //        numero = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            #endregion
            #region SortedList
            SortedList diccio = new SortedList();
            //diccio.Add = ("Hola", "Hello");
            diccio["Bye"] = "Adios";
            diccio["Hello"] = "Hola";
            diccio["how"] = "Como";
            diccio["are"] = "Ser/Estar";
            diccio["you"] = "tu";
            Console.WriteLine("Introduce una frase en ingles para saber su traduccion");
            string frase = Console.ReadLine();
            
            foreach (DictionaryEntry frase in diccio)
            {
                Console.WriteLine(diccio[diccio]);
            }
            #endregion
            #region TablaHash
            Hashtable diccionario = new Hashtable();
            //diccio.Add = ("Hola", "Hello");
            diccionario["Bye"] = "Adios";
            diccionario["Hello"] = "Hola";
            diccionario["how"] = "Como";
            diccionario["are"] = "Ser/Estar";
            diccionario["you"] = "tu";
            Console.WriteLine("Introduce una frase en ingles para saber su traduccion");
            string frasce = Console.ReadLine();

            if (diccionario.ContainsKey(frasce))
            {
                Console.WriteLine(diccionario[diccionario]);
            }
            #endregion
        }
    }
}


