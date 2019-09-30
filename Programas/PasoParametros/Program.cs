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
    static void duplica(in int x) // in es estricto no se puede modificar, se pasa por referencia se vigila que no se modifique
    {
        x= x*2;
    }

    static int suma(int x, int y) //ref se puede inicializar o no
    {
        return x*y;
    }

    static void suma(int x, int y,out int res) // out debe de pasarse las variables sin iniciarlizar nosotros lo debemos de hacer
    {
        res= x+y;
    }

        static void Main(string[] args)
        {
           
           int a =2;
            int b =3;
            int r= suma(a,b);
            int r2;
            suma(a,b,out r2);
           Console.WriteLine(r2);




           //duplica(ref a);
           
           //Persona p= new Persona();
          // Console.WriteLine(p.nombre);
          // Anonymous.Anonimiza(p);
          // Anonymous.cambia(ref p);
          // Console.WriteLine(p.nombre); 

           
        }
    }
}
