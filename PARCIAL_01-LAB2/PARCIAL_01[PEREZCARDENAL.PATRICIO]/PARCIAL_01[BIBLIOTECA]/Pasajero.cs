using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Pasajero : Persona
    {
        public Equipaje equipaje;
        public Pasaporte pasaporte;
        private bool esPremium;

        public bool EsPremium { get => esPremium; set => esPremium = value; }

        public Pasajero (string nombre, string apellido, int edad, Sexo genero, int dni, int numeroPasaporte, Nacionalidad nacionalidad, bool equipajeMano, int cantidadEquipaje, int pesoEquipaje, bool esPremium) : base(nombre, apellido, edad, genero)
        {
            this.pasaporte = new Pasaporte(dni, numeroPasaporte, nacionalidad);
            this.equipaje = new Equipaje(equipajeMano, cantidadEquipaje, pesoEquipaje);
            this.esPremium = esPremium;
        }
        /// <summary>
        /// Metodo que compara el DNI de dos pasajeros
        /// </summary>
        /// <param name="pasajeroUno">Pasajero uno</param>
        /// <param name="pasajeroDos">Pasajero dos</param>
        /// <returns><[TRUE] Si el DNI del pasajero uno es igual al dni del pasajero dos [FALSE] Si los DNI son distintos o si alguno de los pasajeros es [NULL]/returns>
        public static bool operator ==(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            bool validacion = false;

            if (pasajeroUno is not null && pasajeroDos is not null)
            {
                validacion = pasajeroUno.pasaporte.Dni == pasajeroDos.pasaporte.Dni;
            }

            return validacion;
        }
        public static bool operator !=(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            return !(pasajeroUno == pasajeroDos);
        }
        /// <summary>
        /// Metodo que compara el DNI de un pasajero con un DNI en particular
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="dni"></param>
        /// <returns>[TRUE] Si el pasajero posee el mismo DNI que el pasado por parametro [FALSE] Si el pasajero no posee el DNI pasado por parametro o si pasajero es [NULL]</returns>
        public static bool operator ==(Pasajero pasajero, int dni)
        {
            bool validacion = false;

            if (pasajero is not null)
            {
                validacion = pasajero.pasaporte.Dni == dni;
            }

            return validacion;
        }
        public static bool operator !=(Pasajero pasajero, int dni)
        {
            return !(pasajero == dni);
        }

        public override bool Equals(object obj)
        {
            bool validacion = false;

            if (obj is Pasajero)
            {
                validacion = (this == ((Pasajero)obj));
            }
            return validacion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
