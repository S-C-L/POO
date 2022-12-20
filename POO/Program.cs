using POO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte avion = new Transporte();
            avion.nombre = "Avion";
            avion.color = "Gris";
            avion.marca = "XD";
            Console.WriteLine(avion.nombre);
            Console.WriteLine(avion.color);
            Console.WriteLine(avion.marca);

            TipoDeTransporte tipoTransporte = new TipoDeTransporte();
            //tipoTransporte.nombre="";
            Console.WriteLine(tipoTransporte.nombre);
            Console.WriteLine(tipoTransporte.tipo);

            Contenido contenido = new Contenido("Verduras", "Vegetales", 1000);
            contenido.Asegurado = true;
            Console.WriteLine(contenido.Asegurado);

            


        }
    }
}