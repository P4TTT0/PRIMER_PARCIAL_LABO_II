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
        private float valorPorcentualGananciaRegional;
        private float valorPorcentualGananciaExtraRegional;

        public Estadisticas()
        {
            this.destinoPopular = "SIN DESTINOS";
            this.gananciaExtraRegional = 0;
            this.gananciaExtraRegional = 0;
        }

        public string DestinoPopular { get => destinoPopular; set => destinoPopular = value; }
        public float GananciaRegional { get => gananciaRegional; set => gananciaRegional = value; }
        public float GananciaExtraRegional { get => gananciaExtraRegional; set => gananciaExtraRegional = value; }
        public float ValorPorcentualGananciaRegional { get => valorPorcentualGananciaRegional; }
        public float ValorPorcentualGananciaExtraRegional { get => valorPorcentualGananciaExtraRegional; }
        public void CalcularValorPorcentualGanancias()
        {
            if (this.gananciaRegional > this.gananciaExtraRegional)
            {
                this.valorPorcentualGananciaRegional = ((this.gananciaRegional - this.gananciaExtraRegional) / this.gananciaRegional) * 100;
                this.valorPorcentualGananciaExtraRegional = 100 - this.valorPorcentualGananciaRegional;
            }
            else
            {
                this.valorPorcentualGananciaExtraRegional = ((this.gananciaExtraRegional - this.gananciaRegional) / this.gananciaExtraRegional) * 100;
                this.valorPorcentualGananciaRegional = 100 - this.valorPorcentualGananciaExtraRegional;
            }
        }
    }

}
