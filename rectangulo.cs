using System;
namespace Aporte
{
    class rectangulo:Figura, interfaz
    {
        public int bas{set;get;}
        public int altura{set;get;}

        public rectangulo(string nombre,string color,int altura,int bas):base (nombre, color)
        {
            this.altura=altura;
            this.bas=bas;
        }

        public void Calcular()
        {
            int area;
            area=bas*altura;
            Console.WriteLine("El área del tríangulo es: " +area);
        }
    }
}