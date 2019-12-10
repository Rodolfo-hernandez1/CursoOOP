using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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
        public Producto(){}
    }
    class ProductoArch{
        public List<Producto> productos = new List<Producto>();

        public void EscribeProductosTXT(string archivo)
        {
        FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            using(StreamWriter txtOut = new StreamWriter(fs)){
                foreach(Producto p in productos){            
                    txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
                }
            }            
        }

         public void EscribeProductosBIN(string archivo){
            FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
            using(BinaryWriter binOut = new BinaryWriter(fs)){
                foreach(Producto p in productos){            
                    binOut.Write(p.codigo);
                    binOut.Write(p.descripcion);
                    binOut.Write(p.precio);
                    binOut.Write(p.departamento);
                    binOut.Write(p.likes);
                }
            }
        }
        public void LeerProductosBIN(string archivo)
        { 
        FileStream fs1 = new FileStream(archivo,FileMode.Open,FileAccess.Read);         
        using( BinaryReader binIn = new BinaryReader(fs1))
        {            
            while( binIn.PeekChar() != -1 ) 
            {
                Producto producto = new Producto();
                producto.codigo = binIn.ReadString();
                producto.descripcion = binIn.ReadString();
                producto.precio = binIn.ReadDouble();
                producto.departamento = binIn.ReadInt16();
                producto.likes = binIn.ReadInt16();
                      
                productos.Add( producto);
            }
        }
        public void LeerProductosTXT(string archivo)
        {
        FileStream fs1 = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Read);       
        using( StreamReader txtOut = new StreamReader(fs1))
        {
            string line;
            while(  (line =  txtOut.ReadLine()) != null ) 
            {
                string[] columnas = line.Split('|');            
                productos.Add( new Producto(columnas[0],columnas[1], Double.Parse( columnas[2]), int.Parse(columnas[3]),int.Parse(columnas[4])) );
            }                        
        }
        public void GetDepartment(int Depto){
            IEnumerable<Producto> pds =
            from p in productos
            where p.departamento == Depto
            select p;
            Console.WriteLine("productos del departamento: "+Depto);
            foreach(Producto p in pds){
                Console.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.departamento,p.likes);
            }
        }     
    }

    }

    }



    class Program
    {
        static void Main(string[] args)
        {
            
            ProductoArchivo o=new ProductoArchivo();
            o.productos.Add(new Producto("werdfd","jabon",29.99d,2,50));
            o.productos.Add(new Producto("dfsdgs","sabritas",14.99d,3,38));
            o.productos.Add(new Producto("jgfxmd","pantalon",199.99d,4,12));
            o.productos.Add(new Producto("sdnjey","shampoo",39.99d,2,60));
            o.EscribeProductosTXT("productos.txt");
            o.EscribeProductosBIN("productos.bin");
            o.LeeProductosTXT("productos.txt");
            o.GetDepartment(2);
            
        }   
     }
}
