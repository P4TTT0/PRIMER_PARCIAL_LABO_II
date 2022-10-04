using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public abstract class Leaderboard
    {
        protected string nombre;
        protected int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Leaderboard()
        {
            this.nombre = "SIN NOMBRE";
            this.cantidad = 0;
        }
    }
}
