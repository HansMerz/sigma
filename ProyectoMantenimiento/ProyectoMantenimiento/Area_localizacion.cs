using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
   public class Area_localizacion
    {
        public String Localizacion { get; set; }
        public String Centro_costo { get; set; }
        public String id { get; set; }


        public Area_localizacion() { }

        public Area_localizacion(String plocalizaciones, String pcentro_costo, String pid)
        {
            this.Centro_costo = pcentro_costo;
            this.Localizacion = plocalizaciones;
            this.id = pid;
        }

        public DataTable cargarTabla(String val)
        {
            String sql = String.Format("SELECT centrocosto, localizacion FROM area WHERE CONCAT(centrocosto, ' ', localizacion) LIKE '%"+val+"%'");
            DataTable tb = Conexion.Data(sql);
            return tb;
        }
    }
}
