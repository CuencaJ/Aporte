using System;
namespace Aporte
{
    class Figura
    {
        public string nombre{set;get;}
        public string color{set;get;}

        public Figura(string nombre,string color)
        {
            this.nombre=nombre;
            this.color=color;
        }

        public void Imprimir()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Nombre: " +nombre);
            Console.WriteLine("Color: " +color);  
        }
    }
}