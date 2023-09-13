using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Venta
    {
        protected int id;
        protected string comentarios;
        protected string idUsuario;

        public Venta(int id, string comentarios, string idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;

        }


    }
}
