using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Estadisticas
    {
        private string destinoPopular;
        private float gananciaRegional;
        private float gananciaExtraRegional;

        public Estadisticas()
        {
            this.destinoPopular = "SIN DESTINOS";
            this.gananciaExtraRegional = 0;
            this.gananciaExtraRegional = 0;
        }

        public string DestinoPopular { get => destinoPopular; set => destinoPopular = value; }
        public float GananciaRegional { get => gananciaRegional; set => gananciaRegional = value; }
        public float GananciaExtraRegional { get => gananciaExtraRegional; set => gananciaExtraRegional = value; }
    }

}
