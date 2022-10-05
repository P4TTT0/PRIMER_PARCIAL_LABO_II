using System;

namespace PARCIAL_01_BIBLIOTECA_
{
    public class Usuario
    {

        private string usuario;
        private string contraseña;
   
        public Usuario(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        /// <summary>
        /// Comprueba si el USUARIO y la CONTRASEÑA de dos usuarios son iguales
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <param name="usuarioDos"></param>
        /// <returns>[TRUE] Si el USUARIO y la CONTRASEÑA de ambos usuarios son iguales [FALSE] Si el USUARIO y la CONTRASEÑA de ambos usuarios son distintos o si alguno de los usuarios es [NULL]</returns>
        public static bool operator ==(Usuario usuarioUno, Usuario usuarioDos)
        {
            bool validacion = false;

            if (usuarioUno is not null && usuarioDos is not null)
            {
                validacion = usuarioUno.usuario == usuarioDos.usuario && usuarioUno.contraseña == usuarioDos.contraseña;
            }

            return validacion;
        }

        public static bool operator !=(Usuario usuarioUno, Usuario usuarioDos)
        {
            return !(usuarioUno == usuarioDos);
        }

        public override bool Equals(object obj)
        {
            bool validacion = false;
            if (obj is Usuario)
            {
                validacion = this == ((Usuario)obj);
            }

            return validacion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
