using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO

{
   public class Transporte:Complementos
    {
        public string nombre;
        public string color;
        public string marca;
    }

 public class TipoDeTransporte:Complementos
    {
        public string nombre = "Avion";
        public string tipo = "Aereo";

    }

    class Contenido:Complementos
    {
        string nombre;
        string tipo;
        int total;
        private bool asegurado;
        public Contenido(string nombre, string tipo, int total)
        {

            this.nombre = nombre;
            this.tipo = tipo;
            this.total = total;
        }

        public bool Asegurado { get; internal set; }

     

    }


    // public bool Asegurado { get; set; }

}
