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

            cruceros.Add(new Crucero("TTT444", "TBoat", 50, 6, 70, 700, 3));
            cruceros.Add(new Crucero("AJR824", "NavOcean", 27, 3, 1, 400, 0));
            cruceros.Add(new Crucero("JLP051", "Nemo", 17, 2, 3, 350, 2));
            cruceros.Add(new Crucero("OAS001", "MDA", 34, 6, 2, 650, 5));
            cruceros.Add(new Crucero("XXK612", "Crucity", 90, 18, 5, 1200, 7));
            cruceros.Add(new Crucero("FAY206", "Tobio", 45, 12, 3, 700, 1));

            viajes.Add(new Viaje(DateTime.Today, cruceros[1], ViajesExtraRegionales.Bangkok));
            viajes.Add(new Viaje(new DateTime(2022, 4, 29), cruceros[1], ViajesExtraRegionales.Bangkok));
            viajes.Add(new Viaje(DateTime.Today, cruceros[3], ViajesRegionales.PuertoMadryn));
            viajes.Add(new Viaje(new DateTime(2023, 4, 23), cruceros[3], ViajesExtraRegionales.LaHabana));

            viajes[1].Pasajeros.Add(new Pasajero("Juan", "Hernandez", 23, Sexo.Hombre, 41892123, 94844, Nacionalidad.Chilena, true, 1, 25, false));
        }

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
