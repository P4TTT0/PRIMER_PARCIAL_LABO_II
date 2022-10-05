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
        private int disponibilidadPasajes;
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
        public int DisponibilidadPasajes { get => disponibilidadPasajes; }

        private Viaje(DateTime fechaInicioViaje, Crucero crucero)
        {
            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.CalcularCantidadCamarotes();
            this.CalcularCantidadMaximaPasajeros();
            this.CalcularDisponibilidadPasajes();
            this.CalcularPesoTotalBodegaAutomatico();
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
        /// <summary>
        /// Metodo que calcula la cantidad de camarotes premium (35%) y la cantidad de camarotes turistas (RESTANTES)
        /// </summary>
        private void CalcularCantidadCamarotes()
        {
            this.camarotesPremium = (this.crucero * 35) / 100;
            this.camarotesTurista = this.crucero - this.camarotesPremium;
        }
        /// <summary>
        /// Calcula la duracion en HORAS de un viaje EXTRAREGIONAL utilizando un random entre (480 HORAS y 720 HORAS)
        /// </summary>
        private void CalcularDuracionViajeExtraRegional()
        {
            Random duracionViaje = new Random();

            this.duracionViaje = duracionViaje.Next(480, 721);
        }
        /// <summary>
        /// Calcula la duracion en HORAS de un viaje REGIONAL utilizando un random entre (72 HORAS y 360 HORAS)
        /// </summary>
        private void CalcularDuracionViajeRegional()
        {
            Random duracionViaje = new Random();

            this.duracionViaje = duracionViaje.Next(72, 361);
        }
        /// <summary>
        /// Calcula el precio TURISTA y PREMIUM de un viaje EXTRAREGIONAL 
        /// TURISTA: En base a DURACION * $120
        /// PREMIUM: En base al valor TURISTA mas un (20%)
        /// </summary>
        private void CalcularPrecioExtraRegional()
        {
            float valorPasaje = this.duracionViaje * 120;
            this.valorTurista = valorPasaje;
            this.valorPremium = valorPasaje + ((valorPasaje * 20) / 100);
        }
        /// <summary>
        /// Calcula el precio TURISTA y PREMIUM de un viaje EXTRAREGIONAL 
        /// TURISTA: En base a DURACION * $57
        /// PREMIUM: En base al valor TURISTA mas un (20%)
        /// </summary>
        private void CalcularPrecioRegional()
        {
            float valorPasaje = this.duracionViaje * 57;
            this.valorTurista = valorPasaje;
            this.valorPremium = valorPasaje + ((valorPasaje * 20) / 100);
        }
        /// <summary>
        /// Calcula el precio final PREMIUM mediante la suma de su porcentaje IVA (%20)
        /// </summary>
        private void CalcularPrecioFinalPremium()
        {
            int porcentaje = 21;
            this.valorFinalPremium = this.valorPremium + ((valorPremium * porcentaje) / 100);
        }
        /// <summary>
        /// Calcula el precio final TURISTA mediante la suma de su porcentaje IVA (%20)
        /// </summary>
        private void CalcularPrecioFinalTurista()
        {
            int porcentaje = 21;
            this.valorFinalTurista = this.valorTurista + ((valorTurista * porcentaje) / 100);
        }
        /// <summary>
        /// Calcula la cantidad de pasajeros maximos multiplicando la cantidad de camarotes * 4
        /// </summary>
        private void CalcularCantidadMaximaPasajeros()
        {
            this.maxCantidadPasajeros = this.crucero * 4;
        }
        /// <summary>
        /// Calcula la fecha de finalizacion del viaje añadiendole los dias (DURACION EN HORAS / 24 = DIAS) de duracion a la fecha de inicio
        /// </summary>
        private void CalcularFechaDeFinalizacionViaje()
        {
            int duracionViajeDias;
            DateTime auxFechaInicioViaje = this.fechaInicioViaje;
            duracionViajeDias = this.duracionViaje / 24;
            this.fechaFinalViaje = auxFechaInicioViaje.AddDays(duracionViajeDias);
        }
        /// <summary>
        /// Calcula el estado del viaje en comparacion a la fecha actual y a la fehca de incio del viaje
        /// </summary>
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
        /// <summary>
        /// Calcula automaticamente el peso total que tendra el viaje para que el mismo tenga el respectivo peso necesario en relacion a la cantidad de camarotes y a sus posibilidades de peso maxima
        /// </summary>
        private void CalcularPesoTotalBodegaAutomatico()
        {
            this.crucero.Bodega = (this.camarotesTurista * 25) + (this.camarotesPremium * 50);
        }

        public void CalcularDisponibilidadPasajes()
        {
            if (this.pasajeros is not null)
            {
                this.disponibilidadPasajes = this.maxCantidadPasajeros - (this.pasajeros.Count);
            }
            else
            {
                this.disponibilidadPasajes = this.maxCantidadPasajeros;
            }
        }
        /// <summary>
        /// Sobrecarga de [+] para poder añadir un pasajero a la lista
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="pasajero"></param>
        /// <returns>Retorna el viaje</returns>
        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            viaje.pasajeros.Add(pasajero);
            return viaje;
        }
        /// <summary>
        /// Comprueba si un crucero tiene un viaje determinado
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="crucero"></param>
        /// <returns>[TRUE] Si el crucero posee el viaje [FALSE] Si el crucero no posee el viaje o si algunos de los dos son [NULL]</returns>
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
        /// <summary>
        /// Comprueba si existe un pasajero en un viaje mediante la relacion de sus DNI
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="pasajero"></param>
        /// <returns>[TRUE] Si existe dicho pasajero en el viaje [FALSE] Si no existe dicho pasajero en el viaje o si alguno de los dos es [NULL]</returns>
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
        /// <summary>
        /// Metodo que comprueba si el destino pasado por parametro es REGIONAL
        /// </summary>
        /// <param name="destinoComprobar"></param>
        /// <returns>[TRUE] Si el destino es regional [FALSE] Si el destino es extraRegional</returns>
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
        /// <summary>
        /// Sobre escritura del metodo [ToString] retornando el nombre del crucero de determinado viaje
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.crucero.Nombre;
        }
    }
}
