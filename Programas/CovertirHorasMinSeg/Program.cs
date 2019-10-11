using System;

namespace PracticaDuracion
{
    class Duracion
    {
        private int Horas;
        private int Minutos;
        private int Segundos;

    public Duracion(int h, int m,int s)
    {
        Horas=h;
        Minutos=m;
        Segundos=s;
    }

    public void Imprime()
    {
        Console.WriteLine("Horas:{0},Minutos:{1},Segundos:{2}",Horas,Minutos,Segundos);
    }




    }



    class Program
    {
        static void Main(string[] args)
        {
            Duracion Horas= new Duracion(2,0,0);
            Duracion Minutos= new Duracion(0,10,0);
            Duracion Segundos= new Duracion(0,0,20);

            Horas.Imprime();
            Minutos.Imprime();
            Segundos.Imprime();
        }
    }
}

