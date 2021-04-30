using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Persistencia
    {


        protected static Persistencia instancia;


        public Persistencia()
        {

        }

        // Metodo generador de la �nica instancia de la clase retorna instancia de la clase        
        public static Persistencia GetInstancia()
        {
            if (instancia == null)
                instancia = new Persistencia();
            return instancia;
        }





    }


}
