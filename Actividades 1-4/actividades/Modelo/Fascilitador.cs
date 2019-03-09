using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo
{
    class Fascilitador
    {
        private string _nombre;
        private string _edad;
        private string _profesion;

        public Fascilitador()
        {
            this._nombre = "Barron";
            this._edad = "38";
            this._profesion = "Profesor y desarrollador";
        }

        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Profesion { get; set; }
    }
}
