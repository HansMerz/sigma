using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMantenimiento
{
    public class equipos
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String localizacion { get; set; }
        public String fecha_ingreso_plant { get; set; }
        public String fecha_ingreso_siste { get; set; }
        public String costo_equipo { get; set; }
        public String modelo_equipo { get; set; }
        public String serie_equipo { get; set; }
        public String codigo_invetario { get; set; }
        public String peso { get; set; }
        public String altura { get; set; }
        public String ancho { get; set; }
        public String largo { get; set; }
        public String fabricante { get; set; }
        public String marca { get; set; }
        public String realiza_por { get; set; }
        public String caracteristicas_tecn { get; set; }
        public String funcion { get; set; }
        public String Imagen { get; set; }
        public String tipo { get; set; }
        public String capacidad_produccion { get; set; }
        public String voltaje { get; set; }
        public String libra_presion { get; set; }
        public String manual { get; set; }
        public String tipo_aceite { get; set; }
        public String tipo_grasa { get; set; }        
        public String direccion_fabricante { get; set; }
        public String telefono_fabricante { get; set; }
        public String email_fabricante { get; set; }
        public String ano_fabricante { get; set; }
        public String estado { get; set; }
        public String grupo { get; set; }
        public String frecuencia { get; set; }

        public equipos() { }

        public equipos(String pcodigo, String pnombre, String plocalizacion, DateTime pfecha_ingreso_plant, DateTime pfecha_ingreso_siste, String pcosto_equipo, String pmodelo_equipo,
            String pserie_eqúipo, String pcodigo_inventario, String ppeso, String paltura, String pancho, String plargo, String pfabricante, String pmarca, String prealizado_por,
            String pcaracteristicas_tecn, String pfuncion, String pimagen, String ptipo, String pcapacidad_produccion, String pvoltaje, String plibra_presion, String pmanual, String ptipo_aceite,
            String ptipo_grasa, String pnombre_fabricante, String pdireccion_fabricante, String ptelefono_fabricante, String pemail_fabricante, String grupo)
        {

            this.codigo = pcodigo;
            this.nombre = pnombre;
            this.localizacion = plocalizacion;
            this.fecha_ingreso_plant = pfecha_ingreso_plant.ToString();
            this.fecha_ingreso_siste = pfecha_ingreso_siste.ToString();
            this.costo_equipo = pcosto_equipo;
            this.modelo_equipo = pmodelo_equipo;
            this.serie_equipo = pserie_eqúipo;
            this.Imagen = pimagen.ToString();
            this.codigo_invetario = pcodigo_inventario;
            this.peso = ppeso;
            this.altura = paltura;
            this.ancho = pancho;
            this.largo = plargo;
            this.fabricante = pfabricante;
            this.marca = pmarca;
            this.realiza_por = prealizado_por;
            this.caracteristicas_tecn = pcaracteristicas_tecn;
            this.funcion = pfuncion;
            this.Imagen = pimagen;
            this.tipo = ptipo;
            this.capacidad_produccion = pcapacidad_produccion;
            this.voltaje = pvoltaje;
            this.libra_presion = plibra_presion;
            this.manual = pmanual;
            this.tipo_aceite = ptipo_aceite;
            this.tipo_grasa = ptipo_grasa;            
            this.direccion_fabricante = pdireccion_fabricante;
            this.telefono_fabricante = ptelefono_fabricante;
            this.email_fabricante = pemail_fabricante;
            this.grupo = grupo;

        }


    }


}
