using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Pasaporte
    {
        private int dni;
        private int numeroPasaporte;
        private Nacionalidad nacionalidad;

        public Pasaporte(int dni, int numeroPasaporte, Nacionalidad nacionalidad)
        {
            this.dni = dni;
            this.numeroPasaporte = numeroPasaporte;
            this.nacionalidad = nacionalidad;
        }

        public int Dni { get => dni; }
        public int NumeroPasaporte { get => numeroPasaporte; }
        public Nacionalidad Nacionalidad { get => nacionalidad; }

        /// <summary>
        /// Compruba si en un determinado viaje si alguno de los pasajeros tiene el mismo DNI que el pasado por parametro
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="viaje"></param>
        /// <returns>[TRUE] Si existe un pasajero con el DNI pasado por parametro [FALSE] Si no existe ningun pasajero con el DNI pasado por parametro</returns>
        public static bool ValidarDni(int dni, Viaje viaje)
        {
            bool validacion = false;

            foreach (Pasajero pasajero in viaje.Pasajeros)
            {
                if (pasajero == dni)
                {
                    validacion = true;
                    break;
                }
            }
            return validacion;
        }
    }
}
