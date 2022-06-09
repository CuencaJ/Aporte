using System;
namespace Aporte
{
    class Program
    {
        public static void Main (String [] args)
        {
            cuadrado cuadrado1=new cuadrado("Cuadrado","Rojo",4);
            cuadrado1.Imprimir();
            

            rectangulo rectangulo1=new rectangulo("rectangulo","Azul",2,4);
            rectangulo1.Imprimir();
            

            circulo circulo1=new circulo("circulo","verde",3);
            circulo1.Imprimir();


            List<Figura> listafigura=new List<Figura>();
            listafigura.Add(cuadrado1);
            listafigura.Add(rectangulo1);
            listafigura.Add(circulo1);

            foreach(interfaz item in listafigura)
            {
                Console.WriteLine("-------");
                item.Calcular();
            }

        }
    }
}
