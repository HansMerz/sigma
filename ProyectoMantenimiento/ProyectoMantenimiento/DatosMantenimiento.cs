using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{    
    public class DatosMantenimiento
    {
        public String tipo_mantenimiento { get; set; }
        public String fecha_dano { get; set; }
        public String fecha_hora_inicio { get; set; }
        public String fecha_hora_fin { get; set; }
        public String localizacion { get; set; }
        public String grupo { get; set; }
        public String equipo { get; set; }
        public String fecha_prevista { get; set; }
        public String solicita { get; set; }
        public String fecha_solicita { get; set; }
        public String precioTotal { get; set; }
        public String tiempo_ejecucion { get; set; }
        public String proceso { get; set; }
        public String num_orden { get; set; }
        public String id { get; set; }
       /* public String[] encargados { get; set; }
        public String[] herramientas { get; set; }
        public String[] insumos { get; set; }
        public String[] cantidadIns { get; set; }
        public String[] cantidadHer { get; set; }
        public String[] precioIns { get; set; }*/
    }
}
