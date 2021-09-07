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

        //creacion propiedades de la clase Sector
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

        //Creacion constructores
        public Sector(int idSector)
        {
            _idSector = idSector;
        }

        public Sector (double sueldoPorSector)
        {
            _sueldoPorSector = sueldoPorSector;
        }

    }
}
