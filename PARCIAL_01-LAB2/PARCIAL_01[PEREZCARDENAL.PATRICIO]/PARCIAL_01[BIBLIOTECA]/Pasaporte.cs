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
