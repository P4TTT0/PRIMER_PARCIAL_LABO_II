using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int camarotes;
        private int salones;
        private int casinos;
        private int piscinas;
        private int bodega;
        private bool tieneViajeAsignado;

        public Crucero (string matricula, string nombre, int camarotes, int salones, int casinos, int bodega, int piscinas)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.salones = salones;
            this.casinos = casinos;
            this.bodega = bodega;
            this.piscinas = piscinas;
        }

        public static implicit operator int(Crucero objeto)
        {
            return objeto.camarotes;
        }

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Camarotes
        {
            get
            {
                return this.camarotes;
            }
        }

        public int Salones
        {
            get
            {
                return this.salones;
            }
        }
        
        public int Casinos
        {
            get
            {
                return this.casinos;
            }
        }

        public int Piscinas
        {
            get
            {
                return this.piscinas;
            }
        }

        public int Bodega
        {
            get
            {
                return this.bodega;
            }
        }

        public bool TieneViajeAsignado
        {
            get
            {
                return this.tieneViajeAsignado;
            }
            set
            {
                this.tieneViajeAsignado = value;
            }
        }
        private string Mostrar()
        {
            return this.nombre;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
