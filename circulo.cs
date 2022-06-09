using System;
namespace Aporte
{
    class circulo:Figura,interfaz
    {
        public double pi=3.1416;
        public double r2{set;get;}

        public circulo(string nombre,string color,double r2):base (nombre,color)
        {
            this.r2=r2;
        }

        public void Calcular()
        {
            double area;
            area=pi*Math.Pow(r2,2);
            Console.WriteLine("El área del circulo es: " +area);
        }
    }
}