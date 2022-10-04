using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class LeaderboardPasajeros : Leaderboard
    {
        private string apellido;
        public LeaderboardPasajeros(string nombre, string apellido,  int cantidadViajes) : base()
        {
            base.nombre = nombre;
            this.apellido = apellido;
            base.cantidad = cantidadViajes;
        }

        public string Apellido { get => apellido; set => apellido = value; }
    }
}
