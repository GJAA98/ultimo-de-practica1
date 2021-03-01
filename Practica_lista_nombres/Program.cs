using System;

namespace Practica_lista_nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Inserte un nombre:");
                string nombre = Console.ReadLine();
                if(nombre == "")
                {
                    break;
                }
                nombres[i] = nombre;
            }

            Console.WriteLine("Lista de nombres:");
            for (int i = 0; i < 100; i++)
            {
                if (nombres[i] == null)
                {
                    break;
                }
                Console.WriteLine(nombres[i]);
            }

        }
    }
}
