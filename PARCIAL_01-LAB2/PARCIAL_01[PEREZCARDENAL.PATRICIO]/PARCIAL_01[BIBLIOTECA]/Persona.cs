using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_01_BIBLIOTECA_
{
    public abstract class Persona 
    {
        private string nombre;
        private string apellido;
        private int edad;
        private Sexo genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public Sexo Genero { get => genero; set => genero = value; }

        public Persona(string nombre, string apellido, int edad, Sexo genero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }

        public virtual string Mostrar()
        {
            return this.nombre + " " + this.apellido;
        }


       
    }
}
