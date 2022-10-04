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
