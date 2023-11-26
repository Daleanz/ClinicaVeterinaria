using System;
using Generadores;
using Inventario;

namespace Interfaces{
    interface ICajero{
        void VenderProducto(Bodega bodega, Producto producto, int cantidad);
    }
}
