using System;
using System.Collections.Generic;   
namespace peliculas
{
    class Pelicula
{
   private String Titulo;
   private Int16 Año;
   ////private String Pais;
  // private String Director;

  public void setTitulo(String Titulo)  //como los atrivutos son privados tenemos que usar estos meetodos
  {this.Titulo=Titulo;}
  public String getTitulo()//como los atrivutos son privados tenemos que usar estos meetodos
  {return this.Titulo;}

public void setAño(Int16 Año)//como los atrivutos son privados tenemos que usar estos meetodos
  {this.Año=Año;}
  public Int16 getAño()//como los atrivutos son privados tenemos que usar estos meetodos
  {return this.Año;}




    public Pelicula(String Titulo,Int16 Año)// este es el constructor
        {
            this.Titulo= Titulo;
            this.Año=Año;
        }
 }




    class Program
    {
        static void Main()
        {
           // Pelicula p1= new Pelicula("La la land",2016);
            //p1.setTitulo("La la land"); //Se utiliza cuando los atrivutos son privados
           // p1.setAño(2016);             //se uiliza cunado los atrivutos son privados
                
            List<String> Peliculas  = new List<String>();

            Peliculas.Add("Rambo Last Blood");
            Peliculas.Add("It");
            Peliculas.Add("John Wick 3");

             foreach(String Pelicula in Peliculas)
            Console.WriteLine(Pelicula);
                
            //Console.WriteLine("Pelicula: {0}, Ano: {1}", p1.getTitulo(), p1.getAño());


             //Pelicula pelicula1 =new Pelicula();    //De aqui hacia abajo se utiliza cuando los atributos son publicos

             //pelicula1.Titulo = "La forma del agua";     
            // /pelicula1.Año = 2017;
            // pelicula1.Pais = "Estados Unidos";
            // pelicula1.Director = "Guillermo del Toro";  

             //Pelicula pelicula2 =new Pelicula();

            // pelicula2.Titulo = "BirdMan";     
            // pelicula2.Año = 2015;
             /////pelicula2.Pais = "Estados Unidos";
            // pelicula2.Director = "Alejandro Gonzales Iñarritu"; 

            //Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",pelicula1.Titulo,pelicula1.Año,pelicula1.Pais,pelicula1.Director);
           // Console.WriteLine(" Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}",pelicula2.Titulo,pelicula2.Año,pelicula2.Pais,pelicula2.Director);
        }
        
    }
}
