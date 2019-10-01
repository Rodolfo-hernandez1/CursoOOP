using System;
using System.Collections.Generic;

namespace EjemploThiss
{

    class Componente
    {
            public string nombre;
            public Contenedor padre;

            public Componente(string nombre, Contenedor padre)
            {
                this.nombre = nombre;
                this.padre = padre;

            }

            public void print()
            {
                Console.WriteLine($"Soy {nombre} y mi padre es {padre.nombre}");
            }


    }


    class Contenedor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
