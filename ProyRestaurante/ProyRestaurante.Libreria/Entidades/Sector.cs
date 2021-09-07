using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyRestaurante.Libreria.Entidades
{
    class Sector
    {
        private int _idSector;
        private string _nombreSector;
        private double _sueldoPorSector;


        public int CodigoSector
        {
            get { return _idSector; }
        }

        public double SueldoSector
        {
            get { return _sueldoPorSector; }
        }

        public string NombreSector
        {
            get { return _nombreSector; }
        }
    }
}
