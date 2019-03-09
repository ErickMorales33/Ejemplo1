using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo
{
    class Carrera
    {
        private string _nombre;
        private string _duracion;
        private string _descripcion;

        public Carrera()
        {
            this._nombre = "Programación";
            this._duracion = "19 Horas";
            this._descripcion = "Aprende a desarrollar";
        }

        public string Nombre { get; set;}
        public string Duracion { get; set;}
        public string Descripcion { get; set; }
    }
}
