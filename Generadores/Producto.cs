using System;
using Inventario;

namespace Generadores{
    abstract class Producto{
        private string nombreProducto;
        private double precioProducto;
        private int cantidadProducto;

        public Producto(string nombreProducto, double precioProducto, int cantidadProducto){
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.cantidadProducto = cantidadProducto;
        }

        public int CantidadProducto{
            get{return cantidadProducto;}
            set{this.cantidadProducto = value;}
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
