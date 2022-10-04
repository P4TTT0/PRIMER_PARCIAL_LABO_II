using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Equipaje
    {
        private bool equipajeMano;
        private int cantidadEquipaje;
        private int pesoEquipaje;

        public Equipaje(bool equipajeMano, int cantidadEquipaje, int pesoEquipaje)
        {
            this.equipajeMano = equipajeMano;
            this.cantidadEquipaje = cantidadEquipaje;
            this.pesoEquipaje = pesoEquipaje;
        }

        public bool EquipajeMano
        {
            get 
            {
                return this.equipajeMano;
            }
            set
            {
                this.equipajeMano = value;
            }
        }

        public int PesoEquipaje
        {
            get
            {
                return this.pesoEquipaje;
            }
            set
            {
                this.pesoEquipaje = value;
            }
        }

        public int CantidadEquipaje { get => cantidadEquipaje; set => cantidadEquipaje = value; }
    }
}
