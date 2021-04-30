using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class contratoslaborales
    {


        public int idcontrato { get; set; }
        public int idestado { get; set; }
        public int idarl { get; set; }
        public int idcargo { get; set; }
        public int idtipodocumento { get; set; }
        public decimal numerodocumento { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }
        public int salario { get; set; }
        public int usuariocreacion   { get; set; }
        public DateTime fechacreacion { get; set; }


    }
}
