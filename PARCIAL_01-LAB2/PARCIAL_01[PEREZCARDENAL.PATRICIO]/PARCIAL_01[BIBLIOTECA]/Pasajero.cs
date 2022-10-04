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
