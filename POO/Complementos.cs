using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public class Complementos
    {
       public class persona
        {
            protected string nombre;
            protected string sexo;

          public void conduce()
            {
                nombre = "Rosa";
                sexo = "Femenino";
            }

          
        }


        class Combustible
        {
          protected  string nombre;
          protected  int cantidad;


            public void combustible()
            {
                nombre = "Gasolina";
                cantidad = 10;
            }
        }

  
    }
}
