using System;
using Generadores;
using Productos;

namespace Interfaces{
    interface ICompraCliente{
        void ComprarProducto(Producto producto, int cantidad);
        void DevolverProducto(Producto producto, int cantidad);
        int ContarTipoProducto<T>(List<Producto> lista);
    }
}
