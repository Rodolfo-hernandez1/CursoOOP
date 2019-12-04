using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto
{
    class Producto
    {
        public string codigo{get;set;}
        public string descripcion{get;set;}
        public double precio{get;set;}
        public int departamento{get;set;}

        public int likes{get;set;}


        public Producto(string c, string d, double p, int dep, int l)
        {
            codigo = c;
            descripcion = d;
            precio= p;
            departamento =dep;
            likes = l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List <Producto> productos = new List<Producto>();

            productos.Add(new Producto("AWQ","Pluma Negra N1",12.5d,1,100));
            productos.Add(new Producto("AWR","Pluma Azul A1",11.5d,2,50));
            productos.Add(new Producto("AWS","Pluma Roja R1",13.5d,3,75));
            productos.Add(new Producto("AWT","Pluma Verde V1",14.5d,4,125));

            FileStream fs = new FileStream(@"productosProyecto.txt",FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter txtOut = new StreamWriter(fs);


            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
            }
            txtOut.Close();
            Console.WriteLine("Archivo Grabado");
            Console.ReadKey();

            
           }   
        }
}
