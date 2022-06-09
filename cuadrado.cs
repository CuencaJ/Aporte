using System;
namespace Aporte
{
    class cuadrado: Figura, interfaz
    {
        public int lados{set;get;}

        public cuadrado(string nombre,string color,int lados):base (nombre, color)
        {
            this.lados=lados;
        }

        public void Calcular()
        {
            int area;
            area=lados*4;
            Console.WriteLine("El area del cuadrado es: " +area);
        }
    }
}