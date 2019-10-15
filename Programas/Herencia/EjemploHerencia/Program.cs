using System;
using System.Collections.Generic;

namespace EjemploHerencia
{
    class Musico
    {
        protected string nombre;

        public Musico(string n)
        {
            nombre = n;
        }

        public void saluda()
        {
            Console.WriteLine("Hola Soy {0}",nombre);
        }

        public void afinar()
        {
            Console.WriteLine("{0}, afina su instrumento",nombre);
        }

    }

    class bajista:Musico
    {
        private string bajo;

        public bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        }

        public void





    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
