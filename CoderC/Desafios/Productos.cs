using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Productos
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string costo { get; set; }
        public double precioVenta { get; set; }
        public double stock { get; set; }
        public string idUsuario { get; set; }

        public Poductos(int id, string descripcion, string costo, double precioVenta, double stock, string idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;

        }


    }
}
