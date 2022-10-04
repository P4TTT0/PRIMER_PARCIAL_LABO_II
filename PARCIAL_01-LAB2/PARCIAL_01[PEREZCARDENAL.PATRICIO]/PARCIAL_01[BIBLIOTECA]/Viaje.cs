using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Viaje
    {
        private DateTime fechaInicioViaje;
        private DateTime fechaFinalViaje;
        private Crucero crucero;
        private int camarotesPremium;
        private int camarotesTurista;
        private float valorPremium;
        private float valorTurista;
        private float valorFinalPremium;
        private float valorFinalTurista;
        private int duracionViaje;
        private List<Pasajero> pasajeros;
        private int maxCantidadPasajeros;
        private string destino;
        private EstadoViaje estadoViaje;

        public DateTime FechaInicioViaje { get => fechaInicioViaje; set => fechaInicioViaje = value; }
        public DateTime FechaFinalViaje { get => fechaFinalViaje; set => fechaFinalViaje = value; }
        public int CamarotesPremium { get => camarotesPremium; set => camarotesPremium = value; }
        public int CamarotesTurista { get => camarotesTurista; set => camarotesTurista = value; }
        public float ValorPremium { get => valorPremium; set => valorPremium = value; }
        public float ValorTurista { get => valorTurista; set => valorTurista = value; }
        public float ValorFinalPremium { get => valorFinalPremium; set => valorFinalPremium = value; }
        public float ValorFinalTurista { get => valorFinalTurista; set => valorFinalTurista = value; }
        public int DuracionViaje { get => duracionViaje; set => duracionViaje = value; }
        public int MaxCantidadPasajeros { get => maxCantidadPasajeros; set => maxCantidadPasajeros = value; }
        public string Destino { get => destino; set => destino = value; }
        public Crucero Crucero { get => crucero; }
        public EstadoViaje EstadoViaje { get => estadoViaje; set => estadoViaje = value; }
        public List<Pasajero> Pasajeros { get => pasajeros; set => pasajeros = value; }

        private Viaje(DateTime fechaInicioViaje, Crucero crucero)
        {
            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.CalcularCantidadCamarotes();
            this.CalcularCantidadMaximaPasajeros();       
            this.pasajeros = new List<Pasajero>();
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, ViajesExtraRegionales extraRegionales) : this(fechaInicioViaje, crucero)
        {
            this.destino = extraRegionales.ToString();
            this.CalcularDuracionViajeExtraRegional();
            this.CalcularPrecioExtraRegional();
            this.CalcularPrecioFinalPremium();
            this.CalcularPrecioFinalTurista();
            this.CalcularFechaDeFinalizacionViaje();
            this.CalcularEstadoViaje();
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, ViajesRegionales regional) : this(fechaInicioViaje, crucero)
        {
            this.destino = regional.ToString();
            this.CalcularDuracionViajeRegional();
            this.CalcularPrecioRegional();
            this.CalcularPrecioFinalPremium();
            this.CalcularPrecioFinalTurista();
            this.CalcularFechaDeFinalizacionViaje();
            this.CalcularEstadoViaje();
        }

        private void CalcularCantidadCamarotes()
        {
            this.camarotesPremium = (this.crucero * 35) / 100;
            this.camarotesTurista = this.crucero - this.camarotesPremium;
        }

        private void CalcularDuracionViajeExtraRegional()
        {
            Random duracionViaje = new Random();

            this.duracionViaje = duracionViaje.Next(480, 721);
        }

        private void CalcularPrecioExtraRegional()
        {
            float valorPasaje = this.duracionViaje * 120;
            this.valorTurista = valorPasaje;
            this.valorPremium = valorPasaje + ((valorPasaje * 20) / 100);
        }

        private void CalcularDuracionViajeRegional()
        {
            Random duracionViaje = new Random();

            this.duracionViaje = duracionViaje.Next(72, 361);
        }

        private void CalcularPrecioRegional()
        {
            float valorPasaje = this.duracionViaje * 57;
            this.valorTurista = valorPasaje;
            this.valorPremium = valorPasaje + ((valorPasaje * 20) / 100);
        }

        private void CalcularPrecioFinalPremium()
        {
            int porcentaje = 21;
            this.valorFinalPremium = this.valorPremium + ((valorPremium * porcentaje) / 100);
        }

        private void CalcularPrecioFinalTurista()
        {
            int porcentaje = 21;
            this.valorFinalTurista = this.valorTurista + ((valorTurista * porcentaje) / 100);
        }

        private void CalcularCantidadMaximaPasajeros()
        {
            this.maxCantidadPasajeros = this.crucero * 4;
        }

        private void CalcularFechaDeFinalizacionViaje()
        {
            int duracionViajeDias;
            DateTime auxFechaInicioViaje = this.fechaInicioViaje;
            duracionViajeDias = this.duracionViaje / 24;
            this.fechaFinalViaje = auxFechaInicioViaje.AddDays(duracionViajeDias);
        }

        private void CalcularEstadoViaje()
        {
            if (DateTime.Today < this.fechaInicioViaje)
            {
                this.estadoViaje = EstadoViaje.ESPERANDO;
            }
            else
            {
                if (DateTime.Today < this.fechaFinalViaje)
                {
                    this.estadoViaje = EstadoViaje.EN_VIAJE;
                }
                else
                {
                    this.estadoViaje = EstadoViaje.FINALIZADO;
                }
            } 
        }

        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            viaje.pasajeros.Add(pasajero);
            return viaje;
        }

        public static bool operator ==(Viaje viaje, Crucero crucero)
        {
            bool validacion = false;

            if (viaje is not null && crucero is not null)
            {
                validacion = (viaje.crucero.Matricula == crucero.Matricula);
            }

            return validacion;
        }

        public static bool operator !=(Viaje viaje, Crucero crucero)
        {
            return !(viaje == crucero);
        }
        public static bool operator ==(Viaje viajeUno, Viaje viajeDos)
        {
            bool validacion = false;

            if (viajeUno is not null && viajeDos is not null)
            {
                validacion = (viajeUno == viajeDos.crucero && viajeUno.fechaInicioViaje == viajeDos.fechaInicioViaje);
            }

            return validacion;
        }

        public static bool operator !=(Viaje viajeUno, Viaje viajeDos)
        {
            return !(viajeUno == viajeDos);
        }

        public static bool operator ==(Viaje viaje, string crucero)
        {
            bool validacion = false;

            if (viaje is not null && crucero is not null)
            {
                validacion = (viaje.crucero.Nombre == crucero);
            }

            return validacion;
        }

        public static bool operator !=(Viaje viaje, string crucero)
        {
            return !(viaje == crucero);
        }

        public static bool operator ==(Viaje viaje, Pasajero pasajero)
        {
            bool validacion = false;
            if (viaje is not null && pasajero is not null)
            {
                foreach (Pasajero pasajeroUno in viaje.pasajeros)
                {
                    if (pasajeroUno.pasaporte.Dni == pasajero.pasaporte.Dni)
                    {
                        validacion = true;
                    }
                }    
            }
            return validacion;
        }
        public static bool operator !=(Viaje viaje, Pasajero pasajero)
        {
            return !(viaje == pasajero);
        }

        public bool ComprobarDestinoEsRegional(string destinoComprobar)
        {
            bool validacion = false;

            foreach (ViajesRegionales destino in Enum.GetValues(typeof(ViajesRegionales)))
            {
                if (destinoComprobar == destino.ToString())
                {
                    validacion = true;
                    break;
                }
            }

            return validacion;
        }
    }
}
