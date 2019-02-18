using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    public class DatosListaPreventivo
    {
        public String id { get; set; }
        public String numOrden { get; set; }
        public String codEquipo { get; set; }
        public String equipoArea { get; set; }
        public String grupo { get; set; }
        public String localizacion { get; set; }
        public String fechaPrevista { get; set; }
        public String solicita { get; set; }
        public String fechaSolicitud { get; set; }
        public String diasFaltantes { get; set; }
    }
}
