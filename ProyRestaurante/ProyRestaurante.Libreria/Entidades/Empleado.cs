using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyRestaurante.Libreria.Entidades
{
    public class Empleado
    {
        private int _idEmpleado;
        private string _nombreEmpleado;
        private string _apellidoEmpleado;
        private Sector _sueldoEmpleado;
        private Sector _idSector;

        //Creo propiedades para poder usarlas fuera de la clase Empleado
        //Propiedad que me devuelve el id del sector de la clase Sector
        public int SectorEmpleado
        {
            get
            {
                return _idSector.CodigoSector;
            }
        }
        //Propiedad que me devuelve el el sueldo por sector de la clase Sector
        public double SueldoEmpleado
        {
            get
            {
                return _sueldoEmpleado.SueldoSector;
            }
        }        
        public int IdEmpleado
        {
            get
            {
                return _idEmpleado;
            }
        }
        public string NombreEmpleado
        {
            get { return _nombreEmpleado; }
            set { _nombreEmpleado = value; }
        }

        public string ApellidoEmpleado
        {
            get { return _apellidoEmpleado; }
            set { _apellidoEmpleado = value; }
        }




    }
}
