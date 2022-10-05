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
            vendedor.Add(new Usuario("Neiner", "maxi"));
            vendedor.Add(new Usuario("Juan23", "1198"));

            cruceros.Add(new Crucero("TTTT4444", "TBoat", 50, 6, 0, 3));
            cruceros.Add(new Crucero("AJAR8424", "NavOcean", 27, 3, 1, 0));
            cruceros.Add(new Crucero("JLAP0551", "Nemo", 17, 2, 3, 2));
            cruceros.Add(new Crucero("OADS0011", "MDA", 34, 1, 0, 3));
            cruceros.Add(new Crucero("XXAK6142", "Crucity", 90, 4, 3, 4));
            cruceros.Add(new Crucero("FADY2064", "Tobio", 45, 2, 0, 0));
            cruceros.Add(new Crucero("ALSF9920", "DuckBoat", 70, 6, 3, 1));

            viajes.Add(new Viaje(DateTime.Today, cruceros[1], ViajesExtraRegionales.Bangkok));
            viajes.Add(new Viaje(new DateTime(2022, 4, 29), cruceros[1], ViajesExtraRegionales.Taipei));
            viajes.Add(new Viaje(DateTime.Today, cruceros[3], ViajesRegionales.PuertoMadryn));
            viajes.Add(new Viaje(new DateTime(2023, 4, 23), cruceros[3], ViajesExtraRegionales.LaHabana));
            viajes.Add(new Viaje(new DateTime(2022, 12, 10), cruceros[6], ViajesRegionales.Recife));
            viajes.Add(new Viaje(new DateTime(2024, 1, 1), cruceros[2], ViajesExtraRegionales.NuevaYork));
            viajes.Add(new Viaje(new DateTime(2022, 11, 29), cruceros[5], ViajesRegionales.IslaGalápagos));

            viajes[1].Pasajeros.Add(new Pasajero("Juan", "Hernandez", 23, Sexo.Hombre, 41892123, 3289271, Nacionalidad.Argentina, false, 1, 23, false));
            viajes[1].Pasajeros.Add(new Pasajero("Pedro", "Rodriguez", 45, Sexo.Hombre, 33896183, 2229201, Nacionalidad.Argentina, true, 2, 50, true));
            viajes[1].Pasajeros.Add(new Pasajero("Micaela", "Lorenzo", 19, Sexo.Mujer, 43893423, 0012936, Nacionalidad.Boliviana, true, 1, 21, false));
            viajes[1].Pasajeros.Add(new Pasajero("Damian", "Echeverria", 56, Sexo.Hombre, 30383123, 1123499, Nacionalidad.Chilena, false, 1, 25, false));
            viajes[1].Pasajeros.Add(new Pasajero("Ronald", "Watterson", 34, Sexo.Hombre, 39223821, 1928461, Nacionalidad.Uruguaya, true, 2, 30, true));
            viajes[1].Pasajeros.Add(new Pasajero("Sora", "Bounge", 20, Sexo.Hombre, 42844123, 1194844, Nacionalidad.Paraguaya, true, 1, 25, false));

            viajes[2].Pasajeros.Add(new Pasajero("Micaela", "Lorenzo", 19, Sexo.Mujer, 43893423, 0012936, Nacionalidad.Boliviana, true, 1, 21, false));
            viajes[2].Pasajeros.Add(new Pasajero("Damian", "Echeverria", 56, Sexo.Hombre, 30383123, 1123499, Nacionalidad.Chilena, false, 1, 25, false));
            viajes[2].Pasajeros.Add(new Pasajero("Ronald", "Watterson", 34, Sexo.Hombre, 39223821, 1928461, Nacionalidad.Uruguaya, true, 2, 30, true));
            viajes[2].Pasajeros.Add(new Pasajero("Sora", "Bounge", 20, Sexo.Hombre, 42844123, 1194844, Nacionalidad.Paraguaya, true, 1, 25, false));
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
