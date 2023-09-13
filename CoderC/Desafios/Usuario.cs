using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Usuario
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string nombreUsuario;
        protected string contraseña;
        protected string mail;

        public Usuario (int id, string nombre, string apellido,string nombreUsuario, string contraseña,string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.mail = mail;

        }


    }
}
