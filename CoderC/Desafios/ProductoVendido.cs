using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class ProductoVendido
    {
        public int id { get; set; }
        public string idProducto { get; set; }
        public double stock { get; set; }
        public string idVenta { get; set; }

        public PoductoVendido(int id, string idProducto, double stock, string idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;

        }


    }
}
