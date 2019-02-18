using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    public class DatosPlanMantenimiento
    {
        public String codigo { get; set; }
        public String num_orden { get; set; }                        
        public String equipo_area { get; set; }
        public String localizacion { get; set; }
        public String fecha_prevista { get; set; }
        public String solicita { get; set; }
        public String fecha_solicitud { get; set; }
        public String horas_faltantes { get; set; }
        public String frecuencia { get; set; }
    }
}
