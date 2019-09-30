using System;

namespace Prueba
{
    class Persona
    {
        public string nombre;
        public string apellido;


        public Persona()  //constructor
        {
            nombre = "Fulano";
            apellido = "De tal";
        }
    }

    class Anonymous
{
    public static void Anonimiza(Persona p)
    {
        p.nombre = "xxxxx";
        p.apellido = "xxxxxx";
    }

    public static void cambia(ref Persona p)
    {
        p = new Persona ();
        p.nombre= "New";
    }
}

    class Program
    
    {
        static void Main(string[] args)
        {
           
           Persona p= new Persona();
           Console.WriteLine(p.nombre);
           Anonymous.Anonimiza(p);
           Anonymous.cambia(ref p);
           Console.WriteLine(p.nombre); 

           
        }
    }
}

