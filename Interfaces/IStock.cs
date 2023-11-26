using System;
using Generadores;

namespace Interfaces{
    interface IStock{
        void AgregarProductoInventario(Producto producto);
        void EliminarProductoInventario(Producto producto);
        int ObtenerCapacidadRestante();
        void MostrarInventario();
    }
}
