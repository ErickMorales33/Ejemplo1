using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo
{
    class Estudiante
    {
        private long _numerocontrol;
        private string _nombre;
        private int _edad;
        private char _genero;

        public Estudiante()
        {
            this._numerocontrol = 1218100537;
            this._nombre = "Erick Dali González Morales";
            this._edad = 20;
            this._genero = 'H';
        }
        public long NumeroControl { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }

    }
}
