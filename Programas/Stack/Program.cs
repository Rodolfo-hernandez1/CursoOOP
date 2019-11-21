using System;

namespace Stack
{
  class Stack<T>
    {
  
     private T[] elemento;
     readonly int tamaño;
     private int apuntador=0;
    
     public Stack():this(100)
     {
     }
     public Stack(int size)
     {
         tamaño=size;
         elemento=new T[tamaño];
     }

     public void Push(T elemento)
     {         
        if(apuntador>=tamaño)
        {
            throw new StackOverflowException();
        }
        {
            this.elemento[apuntador] = elemento;
            apuntador++;           
        }
     }  

    public T P()
    {
        apuntador--;
        if(apuntador>=0)
        {         
        return elemento[apuntador];
        }
        else{
            apuntador=0;
            throw new InvalidOperationException("Este Stack esta vacio");
        }
        
    }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nums= new Stack<string>(4); 
           
            nums.Push("uno");
            nums.Push("dos");
            nums.Push("tres");

            Console.Write(nums.P());
            Console.Write(nums.P());
            Console.Write(nums.P());
            
        }
    }
}
