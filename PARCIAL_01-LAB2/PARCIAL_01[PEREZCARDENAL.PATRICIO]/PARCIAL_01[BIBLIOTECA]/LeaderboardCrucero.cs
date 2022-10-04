using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class LeaderboardCrucero : Leaderboard
    {
        public LeaderboardCrucero(string nombre, int horas) : base()
        {
            base.nombre = nombre;
            base.cantidad = horas;
        }
    }
}
