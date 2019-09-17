using System;
using System.Collections.Generic;

class Pelicula
{
   public String Titulo;
   public Int16 Año;
   public String Pais;
   public String Director;
    
}



namespace peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
             Pelicula pelicula1 =new Pelicula();

             pelicula1.Titulo = "La forma del agua";     
             pelicula1.Año = 2017;
             pelicula1.Pais = "Estados Unidos";
             pelicula1.Director = "Guillermo del Toro";  

             Pelicula pelicula2 =new Pelicula();

             pelicula2.Titulo = "BirdMan";     
             pelicula2.Año = 2015;
             pelicula2.Pais = "Estados Unidos";
             pelicula2.Director = "Alejandro Gonzales Iñarritu"; 

            Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",pelicula1.Titulo,pelicula1.Año,pelicula1.Pais,pelicula1.Director);
            Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",pelicula2.Titulo,pelicula2.Año,pelicula2.Pais,pelicula2.Director);
        }
        
    }
}
