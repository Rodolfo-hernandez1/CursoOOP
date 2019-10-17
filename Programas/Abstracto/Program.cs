using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    abstract class Figura // es una clase abstracta
    {
    
    protected int ancho,alto;
    protected int px,py;
    protected string color_relleno,color_borde;

    public Figura(int ancho,int alto, int px, int py, string color_relleno, string color_borde)
    {
        this.ancho= ancho;
        this.alto=alto;
        this.px=px;
        this.py=py;
        this.color_relleno=color_relleno;
        this.color_borde=color_borde;
    }
    
    
    public abstract void Dibuja(); //la figura es algo abstracto no se puede dibujar asi que cuando poneos metodo abstracto esto no se puede utilizar, se tiene que usar en las clases que heredan
    
        
    


    }


    class Rectangulo:Figura
    {

        public Rectangulo(int ancho,int alto, int px, int py, string color_relleno, string color_borde):base(ancho,alto,px,py,color_relleno,color_borde)
        {

        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo color {0}, en x: {1} y y:{2}",color_relleno,px,py);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List <Figura> figuras=new List<Figura>;
            figuras.Add(new Rectangulo);
        }
    }
}
