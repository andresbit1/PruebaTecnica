using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class novedadesnomina
    {
        public int idnovedadnomina { get; set; }
        public int idcontrato { get; set; }
        public int periodolaborado { get; set; }
        public int horaslaboradas { get; set; }
        public decimal horaextradiurna { get; set; }
        public decimal horaextranocturna { get; set; }
        public decimal horaextradominical { get; set; }
        public decimal horaextrafestiva { get; set; }
        public decimal descuentos { get; set; }
        public string usuariocreacion { get; set; }
        public DateTime fechacreacion { get; set; }
    }
}
