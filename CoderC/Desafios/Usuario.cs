using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Usuario
    {
        public int id { get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string mail { get; set; }

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
