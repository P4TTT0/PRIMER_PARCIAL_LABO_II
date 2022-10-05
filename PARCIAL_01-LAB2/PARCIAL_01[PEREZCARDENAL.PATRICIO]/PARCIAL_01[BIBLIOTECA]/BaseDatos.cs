using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL_01_BIBLIOTECA_;

namespace PARCIAL_01_BIBLIOTECA_
{
    public static class BaseDatos
    {
        public static List<Usuario> vendedor;
        public static List<Crucero> cruceros;
        public static List<Viaje> viajes;
        public static List<LeaderboardCrucero> clasificacionCruceros;
        public static List<LeaderboardPasajeros> clasificacionPasajeros;
        public static Estadisticas estadisticas;

       
        static BaseDatos()
        {
            vendedor = new List<Usuario>();
            cruceros = new List<Crucero>();
            viajes = new List<Viaje>();
            estadisticas = new Estadisticas();
            clasificacionCruceros = new List<LeaderboardCrucero>();
            clasificacionPasajeros = new List<LeaderboardPasajeros>();

            vendedor.Add(new Usuario("p4ttt0", "admin12"));
            vendedor.Add(new Usuario("Roc_Jou", "rojuu"));

            cruceros.Add(new Crucero("TTT444", "TBoat", 50, 6, 70, 3));
            cruceros.Add(new Crucero("AJR824", "NavOcean", 27, 3, 1, 0));
            cruceros.Add(new Crucero("JLP051", "Nemo", 17, 2, 3, 2));
            cruceros.Add(new Crucero("OAS001", "MDA", 34, 6, 2, 5));
            cruceros.Add(new Crucero("XXK612", "Crucity", 90, 18, 5, 7));
            cruceros.Add(new Crucero("FAY206", "Tobio", 45, 12, 3, 1));

            viajes.Add(new Viaje(DateTime.Today, cruceros[1], ViajesExtraRegionales.Bangkok));
            viajes.Add(new Viaje(new DateTime(2022, 4, 29), cruceros[1], ViajesExtraRegionales.Bangkok));
            viajes.Add(new Viaje(DateTime.Today, cruceros[3], ViajesRegionales.PuertoMadryn));
            viajes.Add(new Viaje(new DateTime(2023, 4, 23), cruceros[3], ViajesExtraRegionales.LaHabana));

            viajes[1].Pasajeros.Add(new Pasajero("Juan", "Hernandez", 23, Sexo.Hombre, 41892123, 94844, Nacionalidad.Chilena, true, 1, 25, false));
        }
        /// <summary>
        /// Metodo que recibe un usuario y comprueba si el mismo se encuentra en la lista de usuarios en la base de datos.
        /// </summary>
        /// <param name="usuarioUno">Usuario recibido</param>
        /// <returns>[TRUE] Si el usuario se encuentra en la lista [FALSE] Si el usuario no se encuentra en la lista</returns>
        public static bool ComprobarDatos(Usuario usuarioUno)
        {
            bool validacion = false;

            foreach (Usuario usuarios in BaseDatos.vendedor)
            {
                if (usuarioUno == usuarios)
                {  
                    validacion = true;
                    break;
                }
            }

            return validacion;
        }
        /// <summary>
        /// Metodo que comprueba si un crucero tiene viaje/s y devuelve mediante el argumento [out] la lista de viajes que contenga
        /// </summary>
        /// <param name="cruceroUno">Crucero a evaluar</param>
        /// <param name="viajes">Lista de viajes que tiene el crucero evaluado</param>
        /// <returns>[TRUE] Si el crucero tiene por lo menos 1 viaje o mas [FALSE] Si el crucero no tiene ningun viaje</returns>
        public static bool ComprobarViajeEnCrucero(Crucero cruceroUno, out List<Viaje> viajes)
        {
            viajes = new List<Viaje>();
            bool validacion = false;

            foreach (Viaje viaje in BaseDatos.viajes)
            {
                if (viaje == cruceroUno)
                {
                    viajes.Add(viaje);
                    validacion = true;
                }
            }
            return validacion;
        }
        public static void ActualizarGananciaRegional(float gananciaRegional)
        {
            BaseDatos.estadisticas.GananciaRegional += gananciaRegional;
        }
        public static void ActualizarGananciaExtraRegional(float gananciaExtraRegional)
        {
            BaseDatos.estadisticas.GananciaExtraRegional += gananciaExtraRegional;
        }
        public static void RecogerGananciasHistoricas()
        {
            foreach (Viaje viaje in BaseDatos.viajes)
            {
                foreach (Pasajero pasajero in viaje.Pasajeros)
                {
                    if (viaje.ComprobarDestinoEsRegional(viaje.Destino))
                    {
                        if (pasajero.EsPremium)
                        {
                            BaseDatos.ActualizarGananciaRegional(viaje.ValorFinalPremium);
                        }
                        else
                        {
                            BaseDatos.ActualizarGananciaRegional(viaje.ValorFinalTurista);
                        }
                    }
                    else
                    {
                        if (pasajero.EsPremium)
                        {
                            BaseDatos.ActualizarGananciaExtraRegional(viaje.ValorFinalPremium);
                        }
                        else
                        {
                            BaseDatos.ActualizarGananciaExtraRegional(viaje.ValorFinalTurista);
                        }
                    }
                }
            }
        }
        public static void ActualizarLeaderboardCrucero()
        {
            LeaderboardCrucero auxCrucero;
            int acumuladorHoras;
            BaseDatos.clasificacionCruceros.Clear();

            foreach (Crucero crucero in BaseDatos.cruceros)
            {
                acumuladorHoras = 0;
                foreach (Viaje viaje in BaseDatos.viajes)
                {
                    if (viaje == crucero)
                    {
                        acumuladorHoras += viaje.DuracionViaje;
                    }
                }
                auxCrucero = new LeaderboardCrucero(crucero.Nombre, acumuladorHoras);
                BaseDatos.clasificacionCruceros.Add(auxCrucero);
            }
        }
        public static void ActualizarLeaderboardPasajeros()
        {
            LeaderboardPasajeros auxPasajero;
            int acumuladorViajes;
            BaseDatos.clasificacionPasajeros.Clear();

            foreach (Viaje viaje in BaseDatos.viajes)
            {
                foreach (Pasajero pasajero in viaje.Pasajeros)
                {
                    acumuladorViajes = 0;
                    foreach (Viaje viajeDos in BaseDatos.viajes)
                    {
                        if (viajeDos == pasajero)
                        {
                            acumuladorViajes++;
                        }
                    }
                    auxPasajero = new LeaderboardPasajeros(pasajero.Nombre, pasajero.Apellido, acumuladorViajes);
                    BaseDatos.clasificacionPasajeros.Add(auxPasajero);
                }
            }
               
        }
    }
}
