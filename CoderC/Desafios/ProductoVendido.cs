using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class ProductoVendido
    {
        protected int id;
        protected string idProducto;
        protected double stock;
        protected string idVenta;

        public PoductoVendido(int id, string idProducto, double stock, string idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;

        }


    }
}
