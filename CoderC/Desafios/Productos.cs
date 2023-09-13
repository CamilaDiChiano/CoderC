using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderC.Desafios
{
    public class Productos
    {
        protected int id;
        protected string descripcion;
        protected string costo;
        protected double precioVenta;
        protected double stock;
        protected string idUsuario;

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
