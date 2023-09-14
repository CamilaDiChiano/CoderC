using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }
        public string idUsuario { get; set; }

        public Venta(int id, string comentarios, string idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;

        }


    }
}
