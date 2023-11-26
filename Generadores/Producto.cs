using System;
using Inventario;

namespace Generadores{
    abstract class Producto{
        private string nombreProducto;
        private double precioProducto;

        public Producto(string nombreProducto, double precioProducto){
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
        }

        public double PrecioProducto{
            get{return precioProducto;}
            set{this.precioProducto = value;}
        }

        public string NombreProducto{
            get{return nombreProducto;}
            set{this.nombreProducto = value;}
        }

        public static Bodega operator +(Bodega bodega, Producto producto){
            bodega.AgregarProductoInventario(producto);
            return bodega;
        }

        public static Bodega operator -(Bodega bodega, Producto producto){
            bodega.EliminarProductoInventario(producto);
            return bodega;
        }
        public abstract void MostrarInformacionProducto();
    }
}
