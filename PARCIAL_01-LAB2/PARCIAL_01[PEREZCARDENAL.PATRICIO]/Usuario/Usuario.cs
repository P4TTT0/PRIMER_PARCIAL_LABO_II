using System;

namespace Usuario
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
        
    }
}
